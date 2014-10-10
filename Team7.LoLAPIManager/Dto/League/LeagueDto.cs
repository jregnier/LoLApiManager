// <copyright file="LeagueDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.League
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class LeagueDto
    {
        [DataMember(Name = "entries")]
        public List<LeagueEntryDto> Entries
        {
            get;
            set;
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Name = "participantId")]
        public string ParticipantId
        {
            get;
            set;
        }

        [DataMember(Name = "queue")]
        public string Queue
        {
            get;
            set;
        }

        [DataMember(Name = "tier")]
        public string Tier
        {
            get;
            set;
        }
    }
}