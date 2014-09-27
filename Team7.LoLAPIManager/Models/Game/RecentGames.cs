namespace Team7.LoLAPIManager.Models.Game
{
    using System.Collections.Generic;

    public class RecentGames
    {
        public List<Game> Games
        {
            get;
            set;
        }

        public long SummonerId
        {
            get;
            set;
        }
    }
}