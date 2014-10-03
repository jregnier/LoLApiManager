// <copyright file="RecentGamesDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Dto.Game
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class RecentGamesDto
    {
        [DataMember(Name = "games")]
        public List<GameDto> Games
        {
            get;
            set;
        }

        [DataMember(Name = "summonerId")]
        public long SummonerId
        {
            get;
            set;
        }
    }
}