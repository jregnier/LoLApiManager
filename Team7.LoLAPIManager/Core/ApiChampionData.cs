// <copyright file="ApiChampionData.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Core
{
    using System.Collections.Generic;

    public enum ApiChampionData
    {
        ALL = 1,
        ALLYTIPS = 2,
        ALLIMAGES = 3,
        BLURB = 4,
        ENEMYTIPS = 5,
        IMAGE = 6,
        INFO = 7,
        LORE = 8,
        PARTYPE = 9,
        PASSIVE = 10,
        RECOMMENDED = 11,
        SKINS = 12,
        SPELLS = 13,
        STATS = 14,
        TAGS = 15
    }

    public static class ChampionData
    {
        private static Dictionary<ApiChampionData, string> _championData;

        public static Dictionary<ApiChampionData, string> GetChampionData
        {
            get
            {
                if (_championData == null)
                {
                    _championData = new Dictionary<ApiChampionData, string>()
                    {
                        { ApiChampionData.ALL, "all" },
                        { ApiChampionData.ALLYTIPS, "allytips" },
                        { ApiChampionData.ALLIMAGES, "allimages" },
                        { ApiChampionData.BLURB, "blurb" },
                        { ApiChampionData.ENEMYTIPS, "enemytips" },
                        { ApiChampionData.IMAGE, "image" },
                        { ApiChampionData.INFO, "info" },
                        { ApiChampionData.LORE, "lore" },
                        { ApiChampionData.PARTYPE, "partype" },
                        { ApiChampionData.PASSIVE, "passive" },
                        { ApiChampionData.RECOMMENDED, "recommended" },
                        { ApiChampionData.SKINS, "skins" },
                        { ApiChampionData.SPELLS, "spells" },
                        { ApiChampionData.STATS, "stats" },
                        { ApiChampionData.TAGS, "tags" },
                    };
                }

                return _championData;
            }
        }
    }
}