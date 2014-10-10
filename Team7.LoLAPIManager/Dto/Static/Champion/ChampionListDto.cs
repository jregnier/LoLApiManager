// <copyright file="ChampionListDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ChampionListDto
    {
        [DataMember(Name = "data")]
        public Dictionary<string, ChampionDto> Data
        {
            get;
            set;
        }

        [DataMember(Name = "format")]
        public string Format
        {
            get;
            set;
        }

        [DataMember(Name = "keys")]
        public Dictionary<string, string> Key
        {
            get;
            set;
        }

        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }

        [DataMember(Name = "version")]
        public string Version
        {
            get;
            set;
        }
    }
}