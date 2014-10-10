// <copyright file="Champion.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing a champion in the game.
    /// </summary>
    public class ChampionList
    {
        public Dictionary<string, Champion> Data
        {
            get;
            set;
        }

        public string Format
        {
            get;
            set;
        }

        public Dictionary<string, string> Key
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