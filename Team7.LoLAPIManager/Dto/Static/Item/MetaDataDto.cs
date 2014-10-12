// <copyright file="MetaDataDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Item
{
    using System.Runtime.Serialization;

    [DataContract]
    public class MetaDataDto
    {
        [DataMember(Name = "isRune")]
        public bool IsRune
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

        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }
    }
}