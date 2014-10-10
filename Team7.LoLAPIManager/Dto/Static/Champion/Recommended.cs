// <copyright file="RecommendedDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class RecommendedDto
    {
        [DataMember(Name = "blocks")]
        public List<BlockDto> Blocks
        {
            get;
            set;
        }

        [DataMember(Name = "champion")]
        public string Champion
        {
            get;
            set;
        }

        [DataMember(Name = "map")]
        public string Map
        {
            get;
            set;
        }

        [DataMember(Name = "mode")]
        public string Mode
        {
            get;
            set;
        }

        [DataMember(Name = "priority")]
        public bool Priority
        {
            get;
            set;
        }

        [DataMember(Name = "title")]
        public string Title
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
    }
}