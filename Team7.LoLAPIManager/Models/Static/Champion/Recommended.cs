// <copyright file="Recommended.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing recommended for a champion.
    /// </summary>
    public class Recommended
    {
        public List<Block> Blocks
        {
            get;
            set;
        }

        public string Champion
        {
            get;
            set;
        }

        public string Map
        {
            get;
            set;
        }

        public string Mode
        {
            get;
            set;
        }

        public bool Priority
        {
            get;
            set;
        }

        public string Title
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