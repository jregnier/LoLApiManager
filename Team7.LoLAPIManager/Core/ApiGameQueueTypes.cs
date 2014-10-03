using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team7.LoLAPIManager.Core
{
    public enum ApiGameQueueTypes
    {
        RANKED_SOLO_5x5,
        RANKED_TEAM_3x3,
        RANKED_TEAM_5x5
    }

    public static class GameQueueTypes
    {
        private static Dictionary<ApiGameQueueTypes, string> _gameQueueTypes;

        public static Dictionary<ApiGameQueueTypes, string> GetGameQueueTypes
        {
            get
            {
                if (_gameQueueTypes == null)
                {
                    _gameQueueTypes = new Dictionary<ApiGameQueueTypes, string>()
                    {
                        { ApiGameQueueTypes.RANKED_SOLO_5x5, "RANKED_SOLO_5x5" },
                        { ApiGameQueueTypes.RANKED_TEAM_3x3, "RANKED_TEAM_3x3" },
                        { ApiGameQueueTypes.RANKED_TEAM_5x5, "RANKED_TEAM_5x5" }
                    };
                }

                return _gameQueueTypes;
            }
        }
    }
}