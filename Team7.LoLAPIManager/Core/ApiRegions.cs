namespace Team7.LoLAPIManager.Core
{
    using System.Collections.Generic;

    public enum ApiRegions
    {
        ER,
        EUNE,
        EUW,
        KR,
        LAN,
        LAS,
        NA,
        OCE,
        RU,
        TR,
        GLOBAL
    }

    public static class Regions
    {
        private static Dictionary<ApiRegions, string> _regions;

        public static Dictionary<ApiRegions, string> GetRegions
        {
            get
            {
                if (_regions == null)
                {
                    _regions = new Dictionary<ApiRegions, string>()
                    {
                        { ApiRegions.ER, "er" },
                        { ApiRegions.EUNE, "eune" },
                        { ApiRegions.EUW, "euw" },
                        { ApiRegions.KR, "kr" },
                        { ApiRegions.LAN, "lan" },
                        { ApiRegions.LAS, "las" },
                        { ApiRegions.NA, "na" },
                        { ApiRegions.OCE, "oce" },
                        { ApiRegions.RU, "ru" },
                        { ApiRegions.TR, "tr" },
                        { ApiRegions.GLOBAL, "global" }
                    };
                }

                return _regions;
            }
        }
    }
}