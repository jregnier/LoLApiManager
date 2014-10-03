// <copyright file="LeagueEntry.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Models.League
{
    /// <summary>
    /// Object representing a league entry for a participant.
    /// </summary>
    public class LeagueEntry
    {
        /// <summary>
        /// Get the league division of the participant.
        /// </summary>
        public string Division
        {
            get;
            set;
        }

        /// <summary>
        /// True if the participant is fresh blood. Otherwise false.
        /// </summary>
        public bool IsFreshBlood
        {
            get;
            set;
        }

        /// <summary>
        /// True the participant is on a hot streak. Otherwise false.
        /// </summary>
        public bool IsHotStreak
        {
            get;
            set;
        }

        /// <summary>
        /// True if the participant is inactive. Otherwise false.
        /// </summary>
        public bool IsInactive
        {
            get;
            set;
        }

        /// <summary>
        /// True if the participant is a veteran. Otherwise false.
        /// </summary>
        public bool IsVeteran
        {
            get;
            set;
        }

        /// <summary>
        /// Get the league points of the participant.
        /// </summary>
        public int LeaguePoints
        {
            get;
            set;
        }

        /// <summary>
        /// Get the <see cref="MiniSeries"/> data for the participant. Only present if the
        /// participant is currently in a mini series.
        /// </summary>
        public MiniSeries MiniSeries
        {
            get;
            set;
        }

        /// <summary>
        /// Get the ID of the participant (i.e., summoner or team) represented by this entry.
        /// </summary>
        public string PlayerOrTeamId
        {
            get;
            set;
        }

        /// <summary>
        /// Get the name of the participant (i.e., summoner or team) represented by this entry.
        /// </summary>
        public string PlayerOrTeamName
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of wins for the participant.
        /// </summary>
        public int Wins
        {
            get;
            set;
        }
    }
}