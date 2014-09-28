// <copyright file="Game.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Models.Game
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents game data for a specific game played.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Champion ID associated with game.
        /// </summary>
        public int ChampionId
        {
            get;
            set;
        }

        /// <summary>
        /// Get the date that end game data was recorded, specified as epoch milliseconds.
        /// </summary>
        public DateTime CreateDate
        {
            get;
            set;
        }

        /// <summary>
        /// Get the list of <see cref="Player"/> associated with the game.
        /// </summary>
        public List<Player> FellowPlayers
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Game ID.
        /// </summary>
        public long GameId
        {
            get;
            set;
        }

        /// <summary>
        /// Get the game mode. (legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, FIRSTBLOOD)
        /// </summary>
        public string GameMode
        {
            get;
            set;
        }

        /// <summary>
        /// Get the game type. (legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        /// </summary>
        public string GameType
        {
            get;
            set;
        }

        /// <summary>
        /// True if invalid flag is set. Otherwise false.
        /// </summary>
        public bool Invalid
        {
            get;
            set;
        }

        /// <summary>
        /// Get the IP Earned in the game.
        /// </summary>
        public int IpEarned
        {
            get;
            set;
        }

        /// <summary>
        /// Get the level reached in the game.
        /// </summary>
        public int Level
        {
            get;
            set;
        }

        /// <summary>
        /// Get the ID of the map played on.
        /// </summary>
        public int MapId
        {
            get;
            set;
        }

        /// <summary>
        /// Get the ID of first summoner spell.
        /// </summary>
        public int Spell1
        {
            get;
            set;
        }

        /// <summary>
        /// Get the ID of second summoner spell.
        /// </summary>
        public int Spell2
        {
            get;
            set;
        }

        /// <summary>
        /// Get the <see cref="RawStats"/> associated with the game for this summoner.
        /// </summary>
        public RawStats Stats
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Game sub-type. (legal values: NONE, NORMAL, BOT, RANKED_SOLO_5x5,
        /// RANKED_PREMADE_3x3, RANKED_PREMADE_5x5, ODIN_UNRANKED, RANKED_TEAM_3x3, RANKED_TEAM_5x5,
        /// NORMAL_3x3, BOT_3x3, CAP_5x5, ARAM_UNRANKED_5x5, ONEFORALL_5x5, FIRSTBLOOD_1x1,
        /// FIRSTBLOOD_2x2, SR_6x6, URF, URF_BOT, NIGHTMARE_BOT)
        /// </summary>
        public string SubType
        {
            get;
            set;
        }

        /// <summary>
        /// Get the team ID associated with game. Team ID 100 is blue team. Team ID 200 is purple team.
        /// </summary>
        public int TeamId
        {
            get;
            set;
        }
    }
}