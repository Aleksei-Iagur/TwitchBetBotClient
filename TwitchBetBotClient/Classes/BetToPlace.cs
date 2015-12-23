using TwitchBetBotClient.Enums;

namespace TwitchBetBotClient.Classes
{
    public class BetToPlace
    {
        public string Username { get; set; }
        public GameResult BetOn { get; set; }
        public int BetAmount { get; set; }
    }
}