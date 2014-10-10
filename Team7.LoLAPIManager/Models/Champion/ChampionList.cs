// <copyright file="ChampionList.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Object representing a list of champions in the game
    /// </summary>
    public class ChampionList
    {
        /// <summary>
        /// The collection of <see cref="Champion"/> information.
        /// </summary>
        public List<Champion> Champions
        {
            get;
            set;
        }
    }
}