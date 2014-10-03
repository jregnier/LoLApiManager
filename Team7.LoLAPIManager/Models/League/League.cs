// <copyright file="Champion.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Models.League
{
    using System.Collections.Generic;

    /// <summary>
    /// Object representing the league for a given summoner.
    /// </summary>
    public class League
    {
        /// <summary>
        /// Get the requested league entries.
        /// </summary>
        public List<LeagueEntry> Entries
        {
            get;
            set;
        }

        /// <summary>
        /// Get the name. This name is an internal place-holder name only. Display and localization
        /// of names in the game client are handled client-side.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Get the relevant participant that is a member of this league (i.e., a requested summoner
        /// ID, a requested team ID, or the ID of a team to which one of the requested summoners
        /// belongs) . Only present when full league is requested so that participant's entry can be
        /// identified. Not present when individual entry is requested.
        /// </summary>
        public string ParticipantId
        {
            get;
            set;
        }

        /// <summary>
        /// Get the league's queue type. (legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        /// </summary>
        public string Queue
        {
            get;
            set;
        }

        /// <summary>
        /// Get the league's tier. (legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD,
        /// SILVER, BRONZE)
        /// </summary>
        public string Tier
        {
            get;
            set;
        }
    }
}