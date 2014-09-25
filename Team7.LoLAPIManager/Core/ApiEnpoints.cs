namespace Team7.LoLAPIManager.Core
{
    using System.Collections.Generic;

    public enum ApiEndPoints
    {
        CHAMPIONS = 1,
        GAME = 2,
        LEAGUE = 3,
        STATIC_DATA = 4,
        STATUS = 5,
        MATCH = 6,
        MATCH_HISTORY = 7,
        STATS = 8,
        SUMMONER = 9,
        TEAM = 10
    }

    public static class EndPoints
    {
        private static Dictionary<ApiEndPoints, string> _endPoints;

        public static Dictionary<ApiEndPoints, string> GetEndPoints
        {
            get
            {
                if (_endPoints == null)
                {
                    _endPoints = new Dictionary<ApiEndPoints, string>()
                    {
                        { ApiEndPoints.CHAMPIONS, "champion" },
                        { ApiEndPoints.GAME, "game" },
                        { ApiEndPoints.LEAGUE, "league" },
                        { ApiEndPoints.STATIC_DATA, "static-data" },
                        { ApiEndPoints.STATUS, "shards" },
                        { ApiEndPoints.MATCH, "match" },
                        { ApiEndPoints.MATCH_HISTORY, "matchhistory" },
                        { ApiEndPoints.STATS, "stats" },
                        { ApiEndPoints.SUMMONER, "summoner" },
                        { ApiEndPoints.TEAM, "team" }
                    };
                }

                return _endPoints;
            }
        }
    }
}