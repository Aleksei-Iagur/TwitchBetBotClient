using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.Util;
using Newtonsoft.Json;
using TwitchBetBotClient.Enums;

namespace TwitchBetBotClient
{
    public class Main
    {
        private readonly BusProxy _bus;
        private IConnection _connection;
        private IConnectionFactory _connectionFactory;
        private List<IMessageConsumer> _messageConsumers;
        private List<string> _onlineUsers;
        private ISession _session;

        public Main()
        {
            _bus = new BusProxy();
            SetUpActiveMq();
            GetOnlineUsersViaBus();
        }

        public bool ChatWriterStatus { get; set; }

        private async void GetOnlineUsersViaBus()
        {
            _onlineUsers = await _bus.GetOnlineUsers();
        }

        private void SetUpActiveMq()
        {
            var busAddress = ConfigurationManager.ConnectionStrings["service-bus"].ConnectionString;
            var uri = new Uri(busAddress);

            try
            {
                _connectionFactory = new NMSConnectionFactory(uri);
                _connection = _connectionFactory.CreateConnection();
                _session = _connection.CreateSession();
                _messageConsumers = new List<IMessageConsumer>();

                SetConsumers();

                _connection.Start();
            }
            catch (Exception exc)
            {
                Print(exc.ToString());
            }
        }

        private void SetConsumers()
        {
            AddConsumer("queue://command.betting.pool.closed");
            AddConsumer("queue://document.chat.writer.status");
        }

        private void AddConsumer(string queueName)
        {
            var endpoint = SessionUtil.GetDestination(_session, queueName);
            var consumer = _session.CreateConsumer(endpoint);
            consumer.Listener += OnMessage;

            _messageConsumers.Add(consumer);
        }

        protected void OnMessage(IMessage receivedMsg)
        {
            try
            {
                var message = receivedMsg as ITextMessage;

                if (message == null) return;

                switch (message.NMSDestination.ToString())
                {
                    case "queue://event.betting.pool.closed":
                        Print("Received a message that betting pool is closed.");
                        // Close bets
                        break;
                    case "queue://document.chat.writer.status":

                        var status = message.Text.StartsWith("<")
                            ? JsonConvert.DeserializeObject<ChatWriterStatus>(message.ToObject().ToString())
                            : JsonConvert.DeserializeObject<ChatWriterStatus>(message.Text);
                        Print($"Received a message that ChatWriter is {status.On}.");
                        ChatWriterStatus = status.On;
                        break;
                }
            }
            catch (Exception exc)
            {
                Print($"An exception has occured: {exc}");
            }
        }

        private void Print(string message)
        {
            Console.WriteLine(message);
        }

        public int GetUsersCount()
        {
            return _onlineUsers?.Count ?? 0;
        }

        public async Task<List<string>> GetTop10()
        {
            var list = await _bus.GetTop10();
            return list.Select(x => $"{x.Name} [{x.Coins}]").ToList();
        }

        public async Task<List<string>> GetOnlineUsers()
        {
            var users = await _bus.GetOnlineUsers();
            _onlineUsers.Clear();
            _onlineUsers.AddRange(users);
            return users;
        }

        public void SetWinner(GameResult winner)
        {
            if (winner == GameResult.Cancel)
            {
                _bus.CancelBetting();
            }
            else
            {
                _bus.SetWinner(winner);
            }
        }

        public void CloseBetting()
        {
            _bus.CloseBetting();
        }

        public void OpenBetting()
        {
            _bus.OpenBetting();
        }

        public void AddUser(string user)
        {
            _bus.SetUserOnline(user);
        }

        public void ShowCurrentBets()
        {
            _bus.ShowCurrentBets();
        }

        public async Task<List<string>> GetCurrentBets()
        {
            return await _bus.GetCurrentBets();
        }

        public void DeletePool()
        {
            _bus.DeletePool();
        }

        public void CreateGame()
        {
            _bus.CreateNewGame();
        }

        public void UpdateGamePlayers(string player1, string player2)
        {
            _bus.UpdateGamePlayers(player1, player2);
        }

        public async Task<List<string>> GetAllPlayers()
        {
            return await _bus.GetAllPlayers();
        }

        public void AddCoinsToUser(string username, int coins, bool withConfirmation)
        {
            if (withConfirmation)
            {
                _bus.AddCoinsToUserWithMessage(username, coins);
            }
            else
            {
                _bus.AddCoinsToUser(username, coins);
            }
        }

        public void AddCoinsToAll(int coins, bool withConfirmation)
        {
            if (withConfirmation)
            {
                _bus.AddCoinsToAllWithMessage(coins);
            }
            else
            {
                _bus.AddCoinsToAllOnline(coins);
            }
        }

        public void AwardViewersOfTheStream()
        {
            _bus.AwardViewersOfTheDay();
        }

        public void DebugMethod()
        {
            _bus.EnterDebugMode();
        }

        public void Send(string text)
        {
            _bus.Say(text, MessagePriority.High);
        }

        public void ChangeChatWriterStatus()
        {
            _bus.ChangeChatWriterStatusTo(!ChatWriterStatus);
        }

        public void GetChatWriterStatus()
        {
            _bus.RequestChatWriterStatus();
        }
    }
}