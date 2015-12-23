using System;
using System.Data;
using System.Windows.Forms;

namespace TwitchBetBotClient
{
    public partial class GamesViewer : Form
    {
        private readonly BusProxy _bus;

        public GamesViewer()
        {
            _bus = new BusProxy();
            InitializeComponent();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            var date = dateTimePicker1.Value;
            dataGridView1.DataSource = CreateDataTableByDate(date);
        }

        private DataTable CreateDataTableByDate(DateTime date)
        {
            //var games = _bus.GetGamesOnDate(date);
            //var table = CreateNewTable();
            //foreach (var game in games)
            //{
            //    table.Rows.Add(game.GameId, game.Player1, game.Player2, game.Result, game.Date, game.BetsOnP1Count, game.BetsOnP1Amount, game.BetsOnP2Count, game.BetsOnP2Amount, game.BetsOnDrawCount, game.BetsOnDrawAmount, game.IsLocked);
            //}
            //return table;
            return null;
        }

        private void GamesViewer_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.Date;
            UpdateData();
        }

        private DataTable CreateNewTable()
        {
            var table = new DataTable();
            table.Columns.Add("GameId");
            table.Columns.Add("Player1Id");
            table.Columns.Add("Player2Id");
            table.Columns.Add("Result");
            table.Columns.Add("Date");
            table.Columns.Add("BetsOnP1Count");
            table.Columns.Add("BetsOnP1Amount");
            table.Columns.Add("BetsOnP2Count");
            table.Columns.Add("BetsOnP2Amount");
            table.Columns.Add("BetsOnDrawCount");
            table.Columns.Add("BetsOnDrawAmount");
            table.Columns.Add("Locked");
            return table;
        }
    }
}