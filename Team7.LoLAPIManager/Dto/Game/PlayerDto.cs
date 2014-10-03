// <copyright file="PlayerDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Dto.Game
{
    using System.Runtime.Serialization;

    [DataContract]
    public class PlayerDto
    {
        [DataMember(Name = "championId")]
        public int ChampionId
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

        [DataMember(Name = "teamId")]
        public int TeamId
        {
            get;
            set;
        }
    }
}