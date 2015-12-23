using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TwitchBetBotClient.Classes;
using TwitchBetBotClient.Enums;

namespace TwitchBetBotClient
{
    public class BusProxy
    {
        private readonly Bus _bus = new Bus();
        public bool PoolLocked => _bus.SendRequestReply<bool>("command.betting.pool.islocked");

        public async Task<List<string>> GetOnlineUsers()
        {
            return await Task.Run(() => _bus.SendRequestReply<List<string>>("command.users.online.get"));
        }

        public async Task<List<User>> GetTop10()
        {
            return await Task.Run(() => _bus.SendRequestReply<List<User>>("command.users.top10.get"));
        }

        public void CancelBetting()
        {
            _bus.SendMessage("command.betting.pool.cancel");
        }

        public void SetWinner(GameResult winner)
        {
            _bus.SendMessage("command.betting.winner.set", winner.ToString());
        }

        public void CloseBetting()
        {
            _bus.SendMessage("command.betting.pool.close");
        }

        public void OpenBetting()
        {
            _bus.SendMessage("command.betting.pool.open");
        }

        public void SetUserOnline(string user)
        {
            _bus.SendMessage("command.users.online.add", user);
        }

        public void ShowCurrentBets()
        {
            _bus.SendMessage("command.betting.bets.current.show");
        }

        public async Task<List<string>> GetCurrentBets()
        {
            return await Task.Run(() => _bus.SendRequestReply<List<string>>("command.betting.bets.current.get"));
        }

        public void DeletePool()
        {
            _bus.SendMessage("command.betting.pool.delete");
        }

        public void CreateNewGame()
        {
            _bus.SendMessage("command.betting.pool.create");
        }

        public void UpdateGamePlayers(string player1, string player2)
        {
            _bus.SendMessage("command.games.current.players.update", new PlayersToUpdate {FirstPlayer = player1, SecondPlayer = player2});
        }

        public async Task<List<string>> GetAllPlayers()
        {
            return await Task.Run(() => _bus.SendRequestReply<List<string>>("command.players.all.get"));
        }

        public void AddCoinsToUserWithMessage(string username, int coins)
        {
            _bus.SendMessage("command.users.user.coins.addwithmessage",
                new UserCoinsChanging {Username = username, CoinsDiff = coins});
        }

        public void AddCoinsToUser(string username, int coins)
        {
            _bus.SendMessage("command.users.user.coins.add",
                new UserCoinsChanging {Username = username, CoinsDiff = coins});
        }

        public void AddCoinsToAllWithMessage(int coins)
        {
            _bus.SendMessage("command.users.coins.addwithmessage", coins);
        }

        public void AddCoinsToAllOnline(int coins)
        {
            _bus.SendMessage("command.users.coins.add", coins);
        }

        public void AwardViewersOfTheDay()
        {
            _bus.SendMessage("command.awards.oftheday.give");
        }

        public void EnterDebugMode()
        {
            _bus.SendMessage("command.debug.mode.enter");
        }

        public void Say(string text, MessagePriority high)
        {
            _bus.SendMessage("command.chat.say", text);
        }

        public IEnumerable GetGamesOnDate(DateTime date)
        {
            return new List<object>();
        }

        public void ChangeChatWriterStatusTo(bool newStatus)
        {
            _bus.SendMessage(newStatus ? "command.chat.writer.on" : "command.chat.writer.off");
        }

        public void RequestChatWriterStatus()
        {
            _bus.SendMessage("command.chat.writer.status");
        }
    }
}