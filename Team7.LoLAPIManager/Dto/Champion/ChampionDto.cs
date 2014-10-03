// <copyright file="ChampionDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Dto.Champion
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ChampionDto
    {
        [DataMember(Name = "active")]
        public bool Active
        {
            get;
            set;
        }

        [DataMember(Name = "botEnabled")]
        public bool BotEnabled
        {
            get;
            set;
        }

        [DataMember(Name = "botMmEnabled")]
        public bool BotMmEnabled
        {
            get;
            set;
        }

        [DataMember(Name = "freeToPlay")]
        public bool FreeToPlay
        {
            get;
            set;
        }

        [DataMember(Name = "id")]
        public long Id
        {
            get;
            set;
        }

        [DataMember(Name = "rankedPlayEnabled")]
        public bool RankedPlayEnabled
        {
            get;
            set;
        }
    }
}