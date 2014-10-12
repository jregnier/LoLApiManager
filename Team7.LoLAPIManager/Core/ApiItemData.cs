// <copyright file="ApiItemData.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Core
{
    using System.Collections.Generic;

    public enum ApiItemData
    {
        ALL = 1,
        COLLOQ = 2,
        CONSUMEONFULL = 3,
        CONSUMED = 4,
        DEPTH = 5,
        FROM = 6,
        GOLD = 7,
        HIDEFROMALL = 8,
        IMAGE = 9,
        INSTORE = 10,
        INTO = 11,
        MAPS = 12,
        REQUIREDCHAMPION = 13,
        SANATIZEDDESCRIPTION = 14,
        SPECIALRECIPE = 15,
        STACKS = 16,
        STATS = 17,
        TAGS = 18,
    }

    public static class ItemData
    {
        private static Dictionary<ApiItemData, string> _itemData;

        public static Dictionary<ApiItemData, string> GetItemData
        {
            get
            {
                if (_itemData == null)
                {
                    _itemData = new Dictionary<ApiItemData, string>()
                    {
                        { ApiItemData.ALL, "all" },
                        { ApiItemData.COLLOQ, "colloq" },
                        { ApiItemData.CONSUMEONFULL, "consumeOnFull" },
                        { ApiItemData.CONSUMED, "consumed" },
                        { ApiItemData.DEPTH, "depth" },
                        { ApiItemData.FROM, "from" },
                        { ApiItemData.GOLD, "gold" },
                        { ApiItemData.HIDEFROMALL, "hideFromAll" },
                        { ApiItemData.IMAGE, "image" },
                        { ApiItemData.INSTORE, "inStore" },
                        { ApiItemData.INTO, "into" },
                        { ApiItemData.MAPS, "maps" },
                        { ApiItemData.REQUIREDCHAMPION, "requiredChampion" },
                        { ApiItemData.SANATIZEDDESCRIPTION, "sanatizedDescription" },
                        { ApiItemData.SPECIALRECIPE, "specialRecipe" },
                        { ApiItemData.STACKS, "stacks" },
                        { ApiItemData.STATS, "stats" },
                        { ApiItemData.TAGS, "tags" },
                    };
                }

                return _itemData;
            }
        }
    }
}