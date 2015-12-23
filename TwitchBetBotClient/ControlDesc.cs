using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using TwitchBetBotClient.Enums;
using TwitchBetBotClient.Properties;
using Timer = System.Timers.Timer;

namespace TwitchBetBotClient
{
    public partial class ControlDesc : Form
    {
        private List<string> _playersList;
        public Main Channel;
        private bool _chatWriterStatus;

        public ControlDesc()
        {
            Channel = new Main();
            InitializeComponent();
        }

        private void button_UsersCount_Click(object sender, EventArgs e)
        {
            UpdateOnlineUsersList();
        }

        private void timer_UsersCount_Tick(object sender, EventArgs e)
        {
            UpdateOnlineUsersList();
            label_UsersCount.Text = Channel.GetUsersCount().ToString();
        }

        private void checkBox_AutoCountUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoCountUsers.Checked)
            {
                timer_UsersCount.Start();
            }
            else
            {
                timer_UsersCount.Stop();
            }
        }

        private void button_ShowTop10InList_Click(object sender, EventArgs e)
        {
            ShowTop10InList();
        }

        private async void ShowTop10InList()
        {
            var users = await Channel.GetTop10();

            listView_Top10.Items.Clear();
            listView_Top10.Items.Add("");
            listView_Top10.Items.Add("     === TOP 10 ===");

            foreach (var user in users)
            {
                listView_Top10.Items.Add("    " + user);
            }
        }

        private async void ControlDesc_Load(object sender, EventArgs e)
        {
            ShowTop10InList();
            _playersList = await Channel.GetAllPlayers();
            RefreshPlayersComboboxes();
        }

        private void RefreshPlayersComboboxes()
        {
            comboBox_Player1.DataSource = null;
            comboBox_Player2.DataSource = null;

            comboBox_Player1.DataSource = _playersList.ToList();
            comboBox_Player2.DataSource = _playersList.ToList();

            comboBox_Player1.Text = "";
            comboBox_Player2.Text = "";
        }

        private void button_ShowUsersInList_Click(object sender, EventArgs e)
        {
            UpdateOnlineUsersList();
        }

        private async void UpdateOnlineUsersList()
        {
            listBox_OnlineUsers.Items.Clear();
            var users = await Channel.GetOnlineUsers();
            listBox_OnlineUsers.Items.AddRange(users.ToArray());
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            SetUserOnline();
        }

        private void SetUserOnline()
        {
            if (string.IsNullOrWhiteSpace(textBox_UserToAdd.Text)) return;
            Channel.AddUser(textBox_UserToAdd.Text);
            textBox_UserToAdd.Text = "";
            UpdateOnlineUsersList();
        }

        private void timer_Bets_Tick(object sender, EventArgs e)
        {
            ShowCurrentBets();
            //ShowTop10InList();
        }

        private void checkBox_AutoUpdateBets_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoUpdateBets.Checked)
            {
                timer_Bets.Start();
            }
            else
            {
                timer_Bets.Stop();
            }
        }

        private void timerTop10_Tick(object sender, EventArgs e)
        {
            ShowTop10InList();
        }

        private void button_UpdatePlayersNames_Click(object sender, EventArgs e)
        {
            UpdateGamePlayers();
        }

        private void button_AddCoinsToUser_Click(object sender, EventArgs e)
        {
            if (listBox_OnlineUsers.SelectedIndex < 0) return;

            var username = listBox_OnlineUsers.SelectedItem.ToString();
            var coins = (int) numericUpDown_AddCoinsToUser.Value;
            var withConfirmation = checkBox_AddCoinsToUserConfirmation.Checked;
            Channel.AddCoinsToUser(username, coins, withConfirmation);
        }

        private void button_AddCoinsToAllOnlineUsers_Click(object sender, EventArgs e)
        {
            var coins = (int) numericUpDown_AddCoinsToAll.Value;
            var withConfirmation = checkBox_AddCoinsToAllConfirmation.Checked;
            Channel.AddCoinsToAll(coins, withConfirmation);
        }

        private void button_ViewersOfTheStream_Click(object sender, EventArgs e)
        {
            Channel.AwardViewersOfTheStream();
        }

        private void textBox_UserToAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            SetUserOnline();
        }

        private void button_DebugMode_Click(object sender, EventArgs e)
        {
            Channel.DebugMethod();
        }

        private void button_SendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            if (string.IsNullOrEmpty(textBox_SendMessage.Text))
            {
                return;
            }

            Channel.Send(textBox_SendMessage.Text);
            textBox_SendMessage.Text = "";
        }

        private void textBox_SendMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }

        #region Betting

        private void button_OpenBetting_Click(object sender, EventArgs e)
        {
            Channel.CreateGame();
            var openBettingSound = new SoundPlayer(Resources.OpenBets);
            openBettingSound.Play();
            RefreshPlayersComboboxes();

            button_OpenBetting.Enabled = false;
            pictureBox_BetsLockUnlock.Visible = false;
            button_CloseBetting.Enabled = true;
            button_CancelBetting.Enabled = true;
            button_UpdatePlayersNames.Enabled = true;

            var delayInSeconds = (int) numericUpDown_DelayInSeconds.Value;
            var finalBetsTimer = new Timer(delayInSeconds*1000);
            finalBetsTimer.Elapsed += (sender2, args) =>
            {
                finalBetsTimer.Enabled = false;

                Channel.OpenBetting();
            };
            finalBetsTimer.Enabled = true;
        }

        private void button_CloseBetting_Click(object sender, EventArgs e)
        {
            button_CloseBetting.Enabled = false;

            UpdateGamePlayers();

            var closeBettingSound = new SoundPlayer(Resources.CloseBets);
            closeBettingSound.Play();

            pictureBox_BetsLockUnlock.Image = Resources.LockBets;
            pictureBox_BetsLockUnlock.Visible = true;
            button_Winner1.Enabled = true;
            button_Winner2.Enabled = true;
            button_Draw.Enabled = true;

            var delayInSeconds = (int) numericUpDown_DelayInSeconds.Value;
            var finalBetsTimer = new Timer(delayInSeconds*1000);
            finalBetsTimer.Elapsed += (sender2, args) =>
            {
                finalBetsTimer.Enabled = false;

                Channel.CloseBetting();
            };

            finalBetsTimer.Enabled = true;
        }

        private void UpdateGamePlayers()
        {
            var player1 = comboBox_Player1.Text;
            var player2 = comboBox_Player2.Text;

            AddToPlayerList(player1);
            AddToPlayerList(player2);

            Channel.UpdateGamePlayers(player1, player2);
        }

        private void AddToPlayerList(string playerName)
        {
            if (_playersList.Contains(playerName)) return;

            _playersList.Add(playerName);
        }

        private void button_Winner1_Click(object sender, EventArgs e)
        {
            SetEndOfTheGame(GameResult.TopPlayerWin);
        }

        private void button_Winner2_Click(object sender, EventArgs e)
        {
            SetEndOfTheGame(GameResult.BottomPlayerWin);
        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            SetEndOfTheGame(GameResult.Draw);
        }

        private void button_CancelBetting_Click(object sender, EventArgs e)
        {
            SetEndOfTheGame(GameResult.Cancel);
        }

        private void SetEndOfTheGame(GameResult option)
        {
            if (string.IsNullOrEmpty(comboBox_Player1.Text) || string.IsNullOrEmpty(comboBox_Player2.Text))
            {
                MessageBox.Show(@"Player names must be filled.", @"Wait a second...", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            pictureBox_BetsLockUnlock.Visible = false;
            button_OpenBetting.Enabled = true;
            button_Winner1.Enabled = false;
            button_Winner2.Enabled = false;
            button_Draw.Enabled = false;
            button_CancelBetting.Enabled = false;
            button_UpdatePlayersNames.Enabled = false;

            comboBox_Player1.Text = "";
            comboBox_Player2.Text = "";

            var delayInSeconds = (int) numericUpDown_DelayInSeconds.Value;
            var delayTimer = new Timer(delayInSeconds*1000);
            delayTimer.Elapsed += (sender2, args) =>
            {
                delayTimer.Enabled = false;

                Channel.SetWinner(option);
                Channel.DeletePool();
            };
            delayTimer.Enabled = true;
        }

        private void button_ShowCurrentBets_Click(object sender, EventArgs e)
        {
            ShowCurrentBets();
        }

        private async void ShowCurrentBets()
        {
            var currentBets = await Channel.GetCurrentBets();
            listView_Bets.Items.Clear();
            foreach (var bet in currentBets)
            {
                listView_Bets.Items.Add(bet);
            }
        }

        #endregion

        private void button_Games_Click(object sender, EventArgs e)
        {
            var viewer = new GamesViewer();
            viewer.Show();
        }

        private void button_TurnChatWriterOnOff_Click(object sender, EventArgs e)
        {
            Channel.ChangeChatWriterStatus();
        }

        private void button_CheckChatWriterStatus_Click(object sender, EventArgs e)
        {
            Channel.GetChatWriterStatus();
            _chatWriterStatus = Channel.ChatWriterStatus;
            label_ChatWriterStatus.Text = _chatWriterStatus ? "ON" : "OFF";
            label_ChatWriterStatus.ForeColor = _chatWriterStatus ? Color.ForestGreen : Color.Black;
        }

        private void timer_ChatWriterStatus_Tick(object sender, EventArgs e)
        {
            Channel.GetChatWriterStatus();
            _chatWriterStatus = Channel.ChatWriterStatus;
            label_ChatWriterStatus.Text = _chatWriterStatus ? "ON" : "OFF";
            label_ChatWriterStatus.ForeColor = _chatWriterStatus ? Color.ForestGreen : Color.Black;
        }

        private void checkBox_ChatWriterStatus_CheckedChanged(object sender, EventArgs e)
        {
            timer_ChatWriterStatus.Enabled = checkBox_ChatWriterStatus.Checked;
        }
    }
}