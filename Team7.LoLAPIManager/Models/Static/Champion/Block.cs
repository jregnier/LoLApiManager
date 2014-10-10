// <copyright file="Block.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing a block.
    /// </summary>
    public class Block
    {
        public List<BlockItem> Items
        {
            get;
            set;
        }

        public bool RecMath
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }
    }
}