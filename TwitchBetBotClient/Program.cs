using System;
using System.Windows.Forms;

namespace TwitchBetBotClient
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new ControlDesc();
            Application.Run(form);
        }
    }
}