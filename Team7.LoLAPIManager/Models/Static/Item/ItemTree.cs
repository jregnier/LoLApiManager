// <copyright file="ItemTree.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Item
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing an item tree for an item.
    /// </summary>
    public class ItemTree
    {
        public string Header
        {
            get;
            set;
        }

        public List<string> Tags
        {
            get;
            set;
        }
    }
}