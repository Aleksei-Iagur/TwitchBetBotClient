namespace TwitchBetBotClient
{
    partial class ControlDesc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "       === Bets ==="}, -1, System.Drawing.Color.Lime, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Loading ...");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDesc));
            this.button_Top10toChat = new System.Windows.Forms.Button();
            this.button_UpdateUsersList = new System.Windows.Forms.Button();
            this.label_UsersCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_UsersCount = new System.Windows.Forms.Timer(this.components);
            this.checkBox_AutoCountUsers = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_AddCoinsToAllConfirmation = new System.Windows.Forms.CheckBox();
            this.numericUpDown_AddCoinsToAll = new System.Windows.Forms.NumericUpDown();
            this.button_AddCoinsToAllOnlineUsers = new System.Windows.Forms.Button();
            this.checkBox_AddCoinsToUserConfirmation = new System.Windows.Forms.CheckBox();
            this.numericUpDown_AddCoinsToUser = new System.Windows.Forms.NumericUpDown();
            this.button_AddCoinsToUser = new System.Windows.Forms.Button();
            this.textBox_UserToAdd = new System.Windows.Forms.TextBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.listBox_OnlineUsers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_Top10 = new System.Windows.Forms.ListView();
            this.button_ShowTop10InList = new System.Windows.Forms.Button();
            this.button_ShowUsersInList = new System.Windows.Forms.Button();
            this.groupBox_Betting = new System.Windows.Forms.GroupBox();
            this.button_UpdatePlayersNames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_DelayInSeconds = new System.Windows.Forms.NumericUpDown();
            this.label_Player2 = new System.Windows.Forms.Label();
            this.button_CancelBetting = new System.Windows.Forms.Button();
            this.label_Player1 = new System.Windows.Forms.Label();
            this.button_Draw = new System.Windows.Forms.Button();
            this.comboBox_Player2 = new System.Windows.Forms.ComboBox();
            this.button_Winner2 = new System.Windows.Forms.Button();
            this.comboBox_Player1 = new System.Windows.Forms.ComboBox();
            this.button_CloseBetting = new System.Windows.Forms.Button();
            this.button_Winner1 = new System.Windows.Forms.Button();
            this.button_OpenBetting = new System.Windows.Forms.Button();
            this.button_ShowCurrentBets = new System.Windows.Forms.Button();
            this.listView_Bets = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_AutoUpdateBets = new System.Windows.Forms.CheckBox();
            this.pictureBox_BetsLockUnlock = new System.Windows.Forms.PictureBox();
            this.timer_Bets = new System.Windows.Forms.Timer(this.components);
            this.timerTop10 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_ViewersOfTheStream = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_DebugMode = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_SendMessage = new System.Windows.Forms.TextBox();
            this.button_SendMessage = new System.Windows.Forms.Button();
            this.button_Games = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox_ChatWriterStatus = new System.Windows.Forms.CheckBox();
            this.button_CheckChatWriterStatus = new System.Windows.Forms.Button();
            this.button_TurnChatWriterOnOff = new System.Windows.Forms.Button();
            this.label_ChatWriterStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_ChatWriterStatus = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AddCoinsToAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AddCoinsToUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_Betting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DelayInSeconds)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BetsLockUnlock)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Top10toChat
            // 
            this.button_Top10toChat.Location = new System.Drawing.Point(7, 19);
            this.button_Top10toChat.Name = "button_Top10toChat";
            this.button_Top10toChat.Size = new System.Drawing.Size(139, 23);
            this.button_Top10toChat.TabIndex = 0;
            this.button_Top10toChat.Text = "Print Top10 in chat";
            this.button_Top10toChat.UseVisualStyleBackColor = true;
            // 
            // button_UpdateUsersList
            // 
            this.button_UpdateUsersList.Location = new System.Drawing.Point(7, 48);
            this.button_UpdateUsersList.Name = "button_UpdateUsersList";
            this.button_UpdateUsersList.Size = new System.Drawing.Size(139, 23);
            this.button_UpdateUsersList.TabIndex = 1;
            this.button_UpdateUsersList.Text = "Update users list";
            this.button_UpdateUsersList.UseVisualStyleBackColor = true;
            this.button_UpdateUsersList.Click += new System.EventHandler(this.button_UsersCount_Click);
            // 
            // label_UsersCount
            // 
            this.label_UsersCount.AutoSize = true;
            this.label_UsersCount.Location = new System.Drawing.Point(74, 21);
            this.label_UsersCount.Name = "label_UsersCount";
            this.label_UsersCount.Size = new System.Drawing.Size(13, 13);
            this.label_UsersCount.TabIndex = 2;
            this.label_UsersCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Users count:";
            // 
            // timer_UsersCount
            // 
            this.timer_UsersCount.Enabled = true;
            this.timer_UsersCount.Interval = 60000;
            this.timer_UsersCount.Tick += new System.EventHandler(this.timer_UsersCount_Tick);
            // 
            // checkBox_AutoCountUsers
            // 
            this.checkBox_AutoCountUsers.AutoSize = true;
            this.checkBox_AutoCountUsers.Checked = true;
            this.checkBox_AutoCountUsers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AutoCountUsers.Location = new System.Drawing.Point(111, 20);
            this.checkBox_AutoCountUsers.Name = "checkBox_AutoCountUsers";
            this.checkBox_AutoCountUsers.Size = new System.Drawing.Size(78, 17);
            this.checkBox_AutoCountUsers.TabIndex = 4;
            this.checkBox_AutoCountUsers.Text = "Auto-count";
            this.checkBox_AutoCountUsers.UseVisualStyleBackColor = true;
            this.checkBox_AutoCountUsers.CheckedChanged += new System.EventHandler(this.checkBox_AutoCountUsers_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_AddCoinsToAllConfirmation);
            this.groupBox1.Controls.Add(this.numericUpDown_AddCoinsToAll);
            this.groupBox1.Controls.Add(this.button_AddCoinsToAllOnlineUsers);
            this.groupBox1.Controls.Add(this.checkBox_AddCoinsToUserConfirmation);
            this.groupBox1.Controls.Add(this.numericUpDown_AddCoinsToUser);
            this.groupBox1.Controls.Add(this.button_AddCoinsToUser);
            this.groupBox1.Controls.Add(this.textBox_UserToAdd);
            this.groupBox1.Controls.Add(this.button_AddUser);
            this.groupBox1.Controls.Add(this.listBox_OnlineUsers);
            this.groupBox1.Controls.Add(this.checkBox_AutoCountUsers);
            this.groupBox1.Controls.Add(this.label_UsersCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(283, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 321);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users in channel";
            // 
            // checkBox_AddCoinsToAllConfirmation
            // 
            this.checkBox_AddCoinsToAllConfirmation.AutoSize = true;
            this.checkBox_AddCoinsToAllConfirmation.Checked = true;
            this.checkBox_AddCoinsToAllConfirmation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AddCoinsToAllConfirmation.Location = new System.Drawing.Point(9, 297);
            this.checkBox_AddCoinsToAllConfirmation.Name = "checkBox_AddCoinsToAllConfirmation";
            this.checkBox_AddCoinsToAllConfirmation.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AddCoinsToAllConfirmation.TabIndex = 13;
            this.checkBox_AddCoinsToAllConfirmation.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_AddCoinsToAll
            // 
            this.numericUpDown_AddCoinsToAll.Location = new System.Drawing.Point(27, 294);
            this.numericUpDown_AddCoinsToAll.Name = "numericUpDown_AddCoinsToAll";
            this.numericUpDown_AddCoinsToAll.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_AddCoinsToAll.TabIndex = 12;
            this.numericUpDown_AddCoinsToAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_AddCoinsToAllOnlineUsers
            // 
            this.button_AddCoinsToAllOnlineUsers.Location = new System.Drawing.Point(77, 292);
            this.button_AddCoinsToAllOnlineUsers.Name = "button_AddCoinsToAllOnlineUsers";
            this.button_AddCoinsToAllOnlineUsers.Size = new System.Drawing.Size(109, 23);
            this.button_AddCoinsToAllOnlineUsers.TabIndex = 11;
            this.button_AddCoinsToAllOnlineUsers.Text = "Add coins to all";
            this.button_AddCoinsToAllOnlineUsers.UseVisualStyleBackColor = true;
            this.button_AddCoinsToAllOnlineUsers.Click += new System.EventHandler(this.button_AddCoinsToAllOnlineUsers_Click);
            // 
            // checkBox_AddCoinsToUserConfirmation
            // 
            this.checkBox_AddCoinsToUserConfirmation.AutoSize = true;
            this.checkBox_AddCoinsToUserConfirmation.Checked = true;
            this.checkBox_AddCoinsToUserConfirmation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AddCoinsToUserConfirmation.Location = new System.Drawing.Point(9, 269);
            this.checkBox_AddCoinsToUserConfirmation.Name = "checkBox_AddCoinsToUserConfirmation";
            this.checkBox_AddCoinsToUserConfirmation.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AddCoinsToUserConfirmation.TabIndex = 10;
            this.checkBox_AddCoinsToUserConfirmation.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_AddCoinsToUser
            // 
            this.numericUpDown_AddCoinsToUser.Location = new System.Drawing.Point(27, 266);
            this.numericUpDown_AddCoinsToUser.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_AddCoinsToUser.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown_AddCoinsToUser.Name = "numericUpDown_AddCoinsToUser";
            this.numericUpDown_AddCoinsToUser.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_AddCoinsToUser.TabIndex = 9;
            this.numericUpDown_AddCoinsToUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_AddCoinsToUser
            // 
            this.button_AddCoinsToUser.Location = new System.Drawing.Point(77, 264);
            this.button_AddCoinsToUser.Name = "button_AddCoinsToUser";
            this.button_AddCoinsToUser.Size = new System.Drawing.Size(109, 23);
            this.button_AddCoinsToUser.TabIndex = 8;
            this.button_AddCoinsToUser.Text = "Add coins to user";
            this.button_AddCoinsToUser.UseVisualStyleBackColor = true;
            this.button_AddCoinsToUser.Click += new System.EventHandler(this.button_AddCoinsToUser_Click);
            // 
            // textBox_UserToAdd
            // 
            this.textBox_UserToAdd.Location = new System.Drawing.Point(9, 237);
            this.textBox_UserToAdd.Name = "textBox_UserToAdd";
            this.textBox_UserToAdd.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserToAdd.TabIndex = 7;
            this.textBox_UserToAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_UserToAdd_KeyDown);
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(115, 235);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(71, 23);
            this.button_AddUser.TabIndex = 6;
            this.button_AddUser.Text = "Add user";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // listBox_OnlineUsers
            // 
            this.listBox_OnlineUsers.FormattingEnabled = true;
            this.listBox_OnlineUsers.Location = new System.Drawing.Point(9, 45);
            this.listBox_OnlineUsers.Name = "listBox_OnlineUsers";
            this.listBox_OnlineUsers.Size = new System.Drawing.Size(177, 186);
            this.listBox_OnlineUsers.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_Top10);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 265);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top 10 viewers";
            // 
            // listView_Top10
            // 
            this.listView_Top10.BackColor = System.Drawing.SystemColors.InfoText;
            this.listView_Top10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Top10.ForeColor = System.Drawing.Color.Lime;
            this.listView_Top10.Location = new System.Drawing.Point(6, 19);
            this.listView_Top10.MultiSelect = false;
            this.listView_Top10.Name = "listView_Top10";
            this.listView_Top10.Scrollable = false;
            this.listView_Top10.Size = new System.Drawing.Size(253, 240);
            this.listView_Top10.TabIndex = 7;
            this.listView_Top10.UseCompatibleStateImageBehavior = false;
            this.listView_Top10.View = System.Windows.Forms.View.List;
            // 
            // button_ShowTop10InList
            // 
            this.button_ShowTop10InList.Location = new System.Drawing.Point(7, 77);
            this.button_ShowTop10InList.Name = "button_ShowTop10InList";
            this.button_ShowTop10InList.Size = new System.Drawing.Size(139, 23);
            this.button_ShowTop10InList.TabIndex = 7;
            this.button_ShowTop10InList.Text = "Show Top10 in List";
            this.button_ShowTop10InList.UseVisualStyleBackColor = true;
            this.button_ShowTop10InList.Click += new System.EventHandler(this.button_ShowTop10InList_Click);
            // 
            // button_ShowUsersInList
            // 
            this.button_ShowUsersInList.Location = new System.Drawing.Point(7, 106);
            this.button_ShowUsersInList.Name = "button_ShowUsersInList";
            this.button_ShowUsersInList.Size = new System.Drawing.Size(139, 23);
            this.button_ShowUsersInList.TabIndex = 8;
            this.button_ShowUsersInList.Text = "ShowUsersInList";
            this.button_ShowUsersInList.UseVisualStyleBackColor = true;
            this.button_ShowUsersInList.Click += new System.EventHandler(this.button_ShowUsersInList_Click);
            // 
            // groupBox_Betting
            // 
            this.groupBox_Betting.Controls.Add(this.button_UpdatePlayersNames);
            this.groupBox_Betting.Controls.Add(this.label1);
            this.groupBox_Betting.Controls.Add(this.numericUpDown_DelayInSeconds);
            this.groupBox_Betting.Controls.Add(this.label_Player2);
            this.groupBox_Betting.Controls.Add(this.button_CancelBetting);
            this.groupBox_Betting.Controls.Add(this.label_Player1);
            this.groupBox_Betting.Controls.Add(this.button_Draw);
            this.groupBox_Betting.Controls.Add(this.comboBox_Player2);
            this.groupBox_Betting.Controls.Add(this.button_Winner2);
            this.groupBox_Betting.Controls.Add(this.comboBox_Player1);
            this.groupBox_Betting.Controls.Add(this.button_CloseBetting);
            this.groupBox_Betting.Controls.Add(this.button_Winner1);
            this.groupBox_Betting.Controls.Add(this.button_OpenBetting);
            this.groupBox_Betting.Location = new System.Drawing.Point(486, 12);
            this.groupBox_Betting.Name = "groupBox_Betting";
            this.groupBox_Betting.Size = new System.Drawing.Size(198, 321);
            this.groupBox_Betting.TabIndex = 9;
            this.groupBox_Betting.TabStop = false;
            this.groupBox_Betting.Text = "Betting management";
            // 
            // button_UpdatePlayersNames
            // 
            this.button_UpdatePlayersNames.Enabled = false;
            this.button_UpdatePlayersNames.Location = new System.Drawing.Point(6, 134);
            this.button_UpdatePlayersNames.Name = "button_UpdatePlayersNames";
            this.button_UpdatePlayersNames.Size = new System.Drawing.Size(186, 23);
            this.button_UpdatePlayersNames.TabIndex = 17;
            this.button_UpdatePlayersNames.Text = "Update names";
            this.button_UpdatePlayersNames.UseVisualStyleBackColor = true;
            this.button_UpdatePlayersNames.Click += new System.EventHandler(this.button_UpdatePlayersNames_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delay in seconds:";
            // 
            // numericUpDown_DelayInSeconds
            // 
            this.numericUpDown_DelayInSeconds.Location = new System.Drawing.Point(131, 22);
            this.numericUpDown_DelayInSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_DelayInSeconds.Name = "numericUpDown_DelayInSeconds";
            this.numericUpDown_DelayInSeconds.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_DelayInSeconds.TabIndex = 16;
            this.numericUpDown_DelayInSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Player2
            // 
            this.label_Player2.AutoSize = true;
            this.label_Player2.Location = new System.Drawing.Point(10, 110);
            this.label_Player2.Name = "label_Player2";
            this.label_Player2.Size = new System.Drawing.Size(55, 13);
            this.label_Player2.TabIndex = 15;
            this.label_Player2.Text = "Player #2:";
            // 
            // button_CancelBetting
            // 
            this.button_CancelBetting.Enabled = false;
            this.button_CancelBetting.Location = new System.Drawing.Point(6, 291);
            this.button_CancelBetting.Name = "button_CancelBetting";
            this.button_CancelBetting.Size = new System.Drawing.Size(186, 23);
            this.button_CancelBetting.TabIndex = 8;
            this.button_CancelBetting.Text = "Cancel betting";
            this.button_CancelBetting.UseVisualStyleBackColor = true;
            this.button_CancelBetting.Click += new System.EventHandler(this.button_CancelBetting_Click);
            // 
            // label_Player1
            // 
            this.label_Player1.AutoSize = true;
            this.label_Player1.Location = new System.Drawing.Point(10, 83);
            this.label_Player1.Name = "label_Player1";
            this.label_Player1.Size = new System.Drawing.Size(55, 13);
            this.label_Player1.TabIndex = 8;
            this.label_Player1.Text = "Player #1:";
            // 
            // button_Draw
            // 
            this.button_Draw.Enabled = false;
            this.button_Draw.Location = new System.Drawing.Point(6, 262);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(186, 23);
            this.button_Draw.TabIndex = 7;
            this.button_Draw.Text = "Draw";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // comboBox_Player2
            // 
            this.comboBox_Player2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Player2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Player2.FormattingEnabled = true;
            this.comboBox_Player2.Location = new System.Drawing.Point(71, 107);
            this.comboBox_Player2.Name = "comboBox_Player2";
            this.comboBox_Player2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Player2.TabIndex = 14;
            // 
            // button_Winner2
            // 
            this.button_Winner2.Enabled = false;
            this.button_Winner2.Location = new System.Drawing.Point(6, 233);
            this.button_Winner2.Name = "button_Winner2";
            this.button_Winner2.Size = new System.Drawing.Size(186, 23);
            this.button_Winner2.TabIndex = 6;
            this.button_Winner2.Text = "Bottom player win";
            this.button_Winner2.UseVisualStyleBackColor = true;
            this.button_Winner2.Click += new System.EventHandler(this.button_Winner2_Click);
            // 
            // comboBox_Player1
            // 
            this.comboBox_Player1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Player1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Player1.FormattingEnabled = true;
            this.comboBox_Player1.Location = new System.Drawing.Point(71, 80);
            this.comboBox_Player1.Name = "comboBox_Player1";
            this.comboBox_Player1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Player1.TabIndex = 13;
            // 
            // button_CloseBetting
            // 
            this.button_CloseBetting.Enabled = false;
            this.button_CloseBetting.Location = new System.Drawing.Point(6, 175);
            this.button_CloseBetting.Name = "button_CloseBetting";
            this.button_CloseBetting.Size = new System.Drawing.Size(186, 23);
            this.button_CloseBetting.TabIndex = 4;
            this.button_CloseBetting.Text = "Close betting";
            this.button_CloseBetting.UseVisualStyleBackColor = true;
            this.button_CloseBetting.Click += new System.EventHandler(this.button_CloseBetting_Click);
            // 
            // button_Winner1
            // 
            this.button_Winner1.Enabled = false;
            this.button_Winner1.Location = new System.Drawing.Point(6, 204);
            this.button_Winner1.Name = "button_Winner1";
            this.button_Winner1.Size = new System.Drawing.Size(186, 23);
            this.button_Winner1.TabIndex = 5;
            this.button_Winner1.Text = "Top player win";
            this.button_Winner1.UseVisualStyleBackColor = true;
            this.button_Winner1.Click += new System.EventHandler(this.button_Winner1_Click);
            // 
            // button_OpenBetting
            // 
            this.button_OpenBetting.Location = new System.Drawing.Point(6, 51);
            this.button_OpenBetting.Name = "button_OpenBetting";
            this.button_OpenBetting.Size = new System.Drawing.Size(186, 23);
            this.button_OpenBetting.TabIndex = 3;
            this.button_OpenBetting.Text = "Open betting";
            this.button_OpenBetting.UseVisualStyleBackColor = true;
            this.button_OpenBetting.Click += new System.EventHandler(this.button_OpenBetting_Click);
            // 
            // button_ShowCurrentBets
            // 
            this.button_ShowCurrentBets.Location = new System.Drawing.Point(7, 135);
            this.button_ShowCurrentBets.Name = "button_ShowCurrentBets";
            this.button_ShowCurrentBets.Size = new System.Drawing.Size(139, 23);
            this.button_ShowCurrentBets.TabIndex = 10;
            this.button_ShowCurrentBets.Text = "Current bets";
            this.button_ShowCurrentBets.UseVisualStyleBackColor = true;
            this.button_ShowCurrentBets.Click += new System.EventHandler(this.button_ShowCurrentBets_Click);
            // 
            // listView_Bets
            // 
            this.listView_Bets.BackColor = System.Drawing.SystemColors.InfoText;
            this.listView_Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Bets.ForeColor = System.Drawing.Color.Lime;
            this.listView_Bets.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView_Bets.Location = new System.Drawing.Point(6, 29);
            this.listView_Bets.MultiSelect = false;
            this.listView_Bets.Name = "listView_Bets";
            this.listView_Bets.Scrollable = false;
            this.listView_Bets.Size = new System.Drawing.Size(253, 108);
            this.listView_Bets.TabIndex = 8;
            this.listView_Bets.UseCompatibleStateImageBehavior = false;
            this.listView_Bets.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_AutoUpdateBets);
            this.groupBox3.Controls.Add(this.pictureBox_BetsLockUnlock);
            this.groupBox3.Controls.Add(this.listView_Bets);
            this.groupBox3.Location = new System.Drawing.Point(12, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 299);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bets info";
            // 
            // checkBox_AutoUpdateBets
            // 
            this.checkBox_AutoUpdateBets.AutoSize = true;
            this.checkBox_AutoUpdateBets.Checked = true;
            this.checkBox_AutoUpdateBets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AutoUpdateBets.Location = new System.Drawing.Point(91, 143);
            this.checkBox_AutoUpdateBets.Name = "checkBox_AutoUpdateBets";
            this.checkBox_AutoUpdateBets.Size = new System.Drawing.Size(84, 17);
            this.checkBox_AutoUpdateBets.TabIndex = 12;
            this.checkBox_AutoUpdateBets.Text = "Auto-update";
            this.checkBox_AutoUpdateBets.UseVisualStyleBackColor = true;
            this.checkBox_AutoUpdateBets.CheckedChanged += new System.EventHandler(this.checkBox_AutoUpdateBets_CheckedChanged);
            // 
            // pictureBox_BetsLockUnlock
            // 
            this.pictureBox_BetsLockUnlock.Image = global::TwitchBetBotClient.Properties.Resources.LockBets;
            this.pictureBox_BetsLockUnlock.Location = new System.Drawing.Point(38, 166);
            this.pictureBox_BetsLockUnlock.Name = "pictureBox_BetsLockUnlock";
            this.pictureBox_BetsLockUnlock.Size = new System.Drawing.Size(137, 127);
            this.pictureBox_BetsLockUnlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BetsLockUnlock.TabIndex = 12;
            this.pictureBox_BetsLockUnlock.TabStop = false;
            this.pictureBox_BetsLockUnlock.Visible = false;
            // 
            // timer_Bets
            // 
            this.timer_Bets.Enabled = true;
            this.timer_Bets.Interval = 10000;
            this.timer_Bets.Tick += new System.EventHandler(this.timer_Bets_Tick);
            // 
            // timerTop10
            // 
            this.timerTop10.Enabled = true;
            this.timerTop10.Interval = 60000;
            this.timerTop10.Tick += new System.EventHandler(this.timerTop10_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_ViewersOfTheStream);
            this.groupBox4.Location = new System.Drawing.Point(696, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 52);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics tricks";
            // 
            // button_ViewersOfTheStream
            // 
            this.button_ViewersOfTheStream.Location = new System.Drawing.Point(7, 19);
            this.button_ViewersOfTheStream.Name = "button_ViewersOfTheStream";
            this.button_ViewersOfTheStream.Size = new System.Drawing.Size(139, 23);
            this.button_ViewersOfTheStream.TabIndex = 11;
            this.button_ViewersOfTheStream.Text = "Viewers of the Stream";
            this.button_ViewersOfTheStream.UseVisualStyleBackColor = true;
            this.button_ViewersOfTheStream.Click += new System.EventHandler(this.button_ViewersOfTheStream_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_Top10toChat);
            this.groupBox5.Controls.Add(this.button_UpdateUsersList);
            this.groupBox5.Controls.Add(this.button_ShowTop10InList);
            this.groupBox5.Controls.Add(this.button_ShowUsersInList);
            this.groupBox5.Controls.Add(this.button_ShowCurrentBets);
            this.groupBox5.Location = new System.Drawing.Point(696, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 168);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Old buttons";
            // 
            // button_DebugMode
            // 
            this.button_DebugMode.Location = new System.Drawing.Point(703, 368);
            this.button_DebugMode.Name = "button_DebugMode";
            this.button_DebugMode.Size = new System.Drawing.Size(139, 23);
            this.button_DebugMode.TabIndex = 19;
            this.button_DebugMode.Text = "Debug mode";
            this.button_DebugMode.UseVisualStyleBackColor = true;
            this.button_DebugMode.Click += new System.EventHandler(this.button_DebugMode_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_SendMessage);
            this.groupBox6.Controls.Add(this.button_SendMessage);
            this.groupBox6.Location = new System.Drawing.Point(283, 339);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(401, 81);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sending messages";
            // 
            // textBox_SendMessage
            // 
            this.textBox_SendMessage.Location = new System.Drawing.Point(9, 19);
            this.textBox_SendMessage.Name = "textBox_SendMessage";
            this.textBox_SendMessage.Size = new System.Drawing.Size(309, 20);
            this.textBox_SendMessage.TabIndex = 9;
            this.textBox_SendMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SendMessage_KeyDown);
            // 
            // button_SendMessage
            // 
            this.button_SendMessage.Location = new System.Drawing.Point(324, 16);
            this.button_SendMessage.Name = "button_SendMessage";
            this.button_SendMessage.Size = new System.Drawing.Size(71, 23);
            this.button_SendMessage.TabIndex = 8;
            this.button_SendMessage.Text = "Send";
            this.button_SendMessage.UseVisualStyleBackColor = true;
            this.button_SendMessage.Click += new System.EventHandler(this.button_SendMessage_Click);
            // 
            // button_Games
            // 
            this.button_Games.Enabled = false;
            this.button_Games.Location = new System.Drawing.Point(703, 397);
            this.button_Games.Name = "button_Games";
            this.button_Games.Size = new System.Drawing.Size(139, 23);
            this.button_Games.TabIndex = 21;
            this.button_Games.Text = "Games";
            this.button_Games.UseVisualStyleBackColor = true;
            this.button_Games.Click += new System.EventHandler(this.button_Games_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox_ChatWriterStatus);
            this.groupBox7.Controls.Add(this.button_CheckChatWriterStatus);
            this.groupBox7.Controls.Add(this.button_TurnChatWriterOnOff);
            this.groupBox7.Controls.Add(this.label_ChatWriterStatus);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(696, 245);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(152, 100);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ChatWriter";
            // 
            // checkBox_ChatWriterStatus
            // 
            this.checkBox_ChatWriterStatus.AutoSize = true;
            this.checkBox_ChatWriterStatus.Checked = true;
            this.checkBox_ChatWriterStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ChatWriterStatus.Location = new System.Drawing.Point(130, 71);
            this.checkBox_ChatWriterStatus.Name = "checkBox_ChatWriterStatus";
            this.checkBox_ChatWriterStatus.Size = new System.Drawing.Size(15, 14);
            this.checkBox_ChatWriterStatus.TabIndex = 4;
            this.toolTip1.SetToolTip(this.checkBox_ChatWriterStatus, "Autocheck every 5 seconds");
            this.checkBox_ChatWriterStatus.UseVisualStyleBackColor = true;
            this.checkBox_ChatWriterStatus.CheckedChanged += new System.EventHandler(this.checkBox_ChatWriterStatus_CheckedChanged);
            // 
            // button_CheckChatWriterStatus
            // 
            this.button_CheckChatWriterStatus.Location = new System.Drawing.Point(7, 67);
            this.button_CheckChatWriterStatus.Name = "button_CheckChatWriterStatus";
            this.button_CheckChatWriterStatus.Size = new System.Drawing.Size(117, 23);
            this.button_CheckChatWriterStatus.TabIndex = 3;
            this.button_CheckChatWriterStatus.Text = "Check status";
            this.button_CheckChatWriterStatus.UseVisualStyleBackColor = true;
            this.button_CheckChatWriterStatus.Click += new System.EventHandler(this.button_CheckChatWriterStatus_Click);
            // 
            // button_TurnChatWriterOnOff
            // 
            this.button_TurnChatWriterOnOff.Location = new System.Drawing.Point(7, 38);
            this.button_TurnChatWriterOnOff.Name = "button_TurnChatWriterOnOff";
            this.button_TurnChatWriterOnOff.Size = new System.Drawing.Size(139, 23);
            this.button_TurnChatWriterOnOff.TabIndex = 2;
            this.button_TurnChatWriterOnOff.Text = "Turn on/off";
            this.button_TurnChatWriterOnOff.UseVisualStyleBackColor = true;
            this.button_TurnChatWriterOnOff.Click += new System.EventHandler(this.button_TurnChatWriterOnOff_Click);
            // 
            // label_ChatWriterStatus
            // 
            this.label_ChatWriterStatus.AutoSize = true;
            this.label_ChatWriterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ChatWriterStatus.Location = new System.Drawing.Point(94, 19);
            this.label_ChatWriterStatus.Name = "label_ChatWriterStatus";
            this.label_ChatWriterStatus.Size = new System.Drawing.Size(30, 13);
            this.label_ChatWriterStatus.TabIndex = 1;
            this.label_ChatWriterStatus.Text = "OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ChatWriter is now";
            // 
            // timer_ChatWriterStatus
            // 
            this.timer_ChatWriterStatus.Enabled = true;
            this.timer_ChatWriterStatus.Interval = 5000;
            this.timer_ChatWriterStatus.Tick += new System.EventHandler(this.timer_ChatWriterStatus_Tick);
            // 
            // ControlDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 594);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.button_Games);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button_DebugMode);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Betting);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlDesc";
            this.Text = "ControlDesc";
            this.Load += new System.EventHandler(this.ControlDesc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AddCoinsToAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AddCoinsToUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Betting.ResumeLayout(false);
            this.groupBox_Betting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DelayInSeconds)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BetsLockUnlock)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Top10toChat;
        private System.Windows.Forms.Button button_UpdateUsersList;
        private System.Windows.Forms.Label label_UsersCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_UsersCount;
        private System.Windows.Forms.CheckBox checkBox_AutoCountUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_Top10;
        private System.Windows.Forms.Button button_ShowTop10InList;
        private System.Windows.Forms.ListBox listBox_OnlineUsers;
        private System.Windows.Forms.Button button_ShowUsersInList;
        private System.Windows.Forms.GroupBox groupBox_Betting;
        private System.Windows.Forms.Button button_CancelBetting;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Button button_Winner2;
        private System.Windows.Forms.Button button_Winner1;
        private System.Windows.Forms.Button button_CloseBetting;
        private System.Windows.Forms.Button button_OpenBetting;
        private System.Windows.Forms.TextBox textBox_UserToAdd;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Button button_ShowCurrentBets;
        private System.Windows.Forms.ListView listView_Bets;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox_BetsLockUnlock;
        private System.Windows.Forms.CheckBox checkBox_AutoUpdateBets;
        private System.Windows.Forms.Timer timer_Bets;
        private System.Windows.Forms.ComboBox comboBox_Player1;
        private System.Windows.Forms.ComboBox comboBox_Player2;
        private System.Windows.Forms.Label label_Player1;
        private System.Windows.Forms.Label label_Player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_DelayInSeconds;
        private System.Windows.Forms.Timer timerTop10;
        private System.Windows.Forms.Button button_UpdatePlayersNames;
        private System.Windows.Forms.NumericUpDown numericUpDown_AddCoinsToUser;
        private System.Windows.Forms.Button button_AddCoinsToUser;
        private System.Windows.Forms.CheckBox checkBox_AddCoinsToUserConfirmation;
        private System.Windows.Forms.NumericUpDown numericUpDown_AddCoinsToAll;
        private System.Windows.Forms.Button button_AddCoinsToAllOnlineUsers;
        private System.Windows.Forms.CheckBox checkBox_AddCoinsToAllConfirmation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_ViewersOfTheStream;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_DebugMode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_SendMessage;
        private System.Windows.Forms.Button button_SendMessage;
        private System.Windows.Forms.Button button_Games;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_CheckChatWriterStatus;
        private System.Windows.Forms.Button button_TurnChatWriterOnOff;
        private System.Windows.Forms.Label label_ChatWriterStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_ChatWriterStatus;
        private System.Windows.Forms.Timer timer_ChatWriterStatus;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}