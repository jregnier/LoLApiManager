// <copyright file="Champion.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Champion
{
    /// <summary>
    /// Data object representing a champion in the game.
    /// </summary>
    public class Champion
    {
        /// <summary>
        /// True if the champion is active. Otherwise false.
        /// </summary>
        public bool Active
        {
            get;
            set;
        }

        /// <summary>
        /// True if bot enabled flag (for custom games). Otherwise false.
        /// </summary>
        public bool BotEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// True if Bot Match Made enabled flag (for Co-op vs. AI games). Otherwise false.
        /// </summary>
        public bool BotMmEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// True if the champion is free to play. Free to play champions are rotated periodically.
        /// Otherwise false.
        /// </summary>
        public bool FreeToPlay
        {
            get;
            set;
        }

        /// <summary>
        /// Champion ID. For static information correlating to champion IDs, please refer to the LoL
        /// Static Data API.
        /// </summary>
        public long Id
        {
            get;
            set;
        }

        /// <summary>
        /// True if ranked play enabled flag. Otherwise false.
        /// </summary>
        public bool RankedPlayEnabled
        {
            get;
            set;
        }
    }
}