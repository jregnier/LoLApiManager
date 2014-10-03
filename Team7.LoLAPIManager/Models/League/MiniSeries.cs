// <copyright file="MiniSeries.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Models.League
{
    /// <summary>
    /// Object representing data for a given mini series.
    /// </summary>
    public class MiniSeries
    {
        /// <summary>
        /// Get number of current losses in the mini series.
        /// </summary>
        public int Losses
        {
            get;
            set;
        }

        /// <summary>
        ///Get the current, sequential mini series progress where 'W' represents a win, 'L' represents a loss, and 'N' represents a game that hasn't been played yet.
        /// </summary>
        public string Progress
        {
            get;
            set;
        }

        /// <summary>
        /// Get number of wins required for promotion.
        /// </summary>
        public int Target
        {
            get;
            set;
        }

        /// <summary>
        /// Get number of current wins in the mini series.
        /// </summary>
        public int Wins
        {
            get;
            set;
        }
    }
}