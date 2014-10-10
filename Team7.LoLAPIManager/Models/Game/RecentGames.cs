// <copyright file="RecentGames.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Game
{
    using System.Collections.Generic;

    /// <summary>
    /// Holds data for a specific summoner for the last 10 games played.
    /// </summary>
    public class RecentGames
    {
        /// <summary>
        /// Get the collection of <see cref="Game"/> played (max 10).
        /// </summary>
        public List<Game> Games
        {
            get;
            set;
        }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public long SummonerId
        {
            get;
            set;
        }
    }
}