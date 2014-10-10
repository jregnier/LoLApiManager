// <copyright file="Player.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Game
{
    /// <summary>
    /// Represents another player that was involved in the game played.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Get the champion id associated with player.
        /// </summary>
        public int ChampionId
        {
            get;
            set;
        }

        /// <summary>
        /// Get the summoner id associated with player.
        /// </summary>
        public long SummonerId
        {
            get;
            set;
        }

        /// <summary>
        /// Get the team id associated with player.
        /// </summary>
        public int TeamId
        {
            get;
            set;
        }
    }
}