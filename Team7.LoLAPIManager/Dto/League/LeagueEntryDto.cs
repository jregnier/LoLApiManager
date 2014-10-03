// <copyright file="LeagueEntryDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Dto.League
{
    using System.Runtime.Serialization;

    [DataContract]
    public class LeagueEntryDto
    {
        [DataMember(Name = "division")]
        public string Division
        {
            get;
            set;
        }

        [DataMember(Name = "isFreshBlood")]
        public bool IsFreshBlood
        {
            get;
            set;
        }

        [DataMember(Name = "isHotStreak")]
        public bool IsHotStreak
        {
            get;
            set;
        }

        [DataMember(Name = "isInactive")]
        public bool IsInactive
        {
            get;
            set;
        }

        [DataMember(Name = "isVeteran")]
        public bool IsVeteran
        {
            get;
            set;
        }

        [DataMember(Name = "leaguePoints")]
        public int LeaguePoints
        {
            get;
            set;
        }

        [DataMember(Name = "miniSeries")]
        public MiniSeriesDto MiniSeries
        {
            get;
            set;
        }

        [DataMember(Name = "playerOrTeamId")]
        public string PlayerOrTeamId
        {
            get;
            set;
        }

        [DataMember(Name = "playerOrTeamName")]
        public string PlayerOrTeamName
        {
            get;
            set;
        }

        [DataMember(Name = "wins")]
        public int Wins
        {
            get;
            set;
        }
    }
}