// <copyright file="ApiItemListData.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Core
{
    using System.Collections.Generic;

    public enum ApiItemListData
    {
        ALL = 1,
        COLLOQ = 2,
        CONSUMEONFULL = 3,
        CONSUMED = 4,
        DEPTH = 5,
        FROM = 6,
        GOLD = 7,
        GROUPS = 8,
        HIDEFROMALL = 9,
        IMAGE = 10,
        INSTORE = 11,
        INTO = 12,
        MAPS = 13,
        REQUIREDCHAMPION = 14,
        SANATIZEDDESCRIPTION = 15,
        SPECIALRECIPE = 16,
        STACKS = 17,
        STATS = 18,
        TAGS = 19,
        TREE = 20
    }

    public static class ItemListData
    {
        private static Dictionary<ApiItemListData, string> _itemListData;

        public static Dictionary<ApiItemListData, string> GetItemListData
        {
            get
            {
                if (_itemListData == null)
                {
                    _itemListData = new Dictionary<ApiItemListData, string>()
                    {
                        { ApiItemListData.ALL, "all" },
                        { ApiItemListData.COLLOQ, "colloq" },
                        { ApiItemListData.CONSUMEONFULL, "consumeOnFull" },
                        { ApiItemListData.CONSUMED, "consumed" },
                        { ApiItemListData.DEPTH, "depth" },
                        { ApiItemListData.FROM, "from" },
                        { ApiItemListData.GOLD, "gold" },
                        { ApiItemListData.GROUPS, "groups" },
                        { ApiItemListData.HIDEFROMALL, "hideFromAll" },
                        { ApiItemListData.IMAGE, "image" },
                        { ApiItemListData.INSTORE, "inStore" },
                        { ApiItemListData.INTO, "into" },
                        { ApiItemListData.MAPS, "maps" },
                        { ApiItemListData.REQUIREDCHAMPION, "requiredChampion" },
                        { ApiItemListData.SANATIZEDDESCRIPTION, "sanatizedDescription" },
                        { ApiItemListData.SPECIALRECIPE, "specialRecipe" },
                        { ApiItemListData.STACKS, "stacks" },
                        { ApiItemListData.STATS, "stats" },
                        { ApiItemListData.TAGS, "tags" },
                        { ApiItemListData.TREE, "tree" },
                    };
                }

                return _itemListData;
            }
        }
    }
}