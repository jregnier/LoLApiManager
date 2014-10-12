// <copyright file="ItemList.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
using System.Collections.Generic;

namespace Team7.LoLApiManager.Models.Static.Item
{
    /// <summary>
    /// Data object representing a list of data for different items.
    /// </summary>
    public class ItemList
    {
        public BasicData Basic
        {
            get;
            set;
        }

        public Dictionary<string, Item> Data
        {
            get;
            set;
        }

        public List<Group> Groups
        {
            get;
            set;
        }

        public List<ItemTree> Tree
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }
    }
}