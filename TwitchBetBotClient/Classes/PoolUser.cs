namespace TwitchBetBotClient.Classes
{
    public class PoolUser
    {
        public PoolUser(int betOn, int betAmount)
        {
            BetOn = betOn;
            BetAmount = betAmount;
        }

        public int BetOn { get; set; }
        public int BetAmount { get; set; }
    }
}