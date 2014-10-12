// <copyright file="ItemTreeDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Item
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ItemTreeDto
    {
        [DataMember(Name = "header")]
        public string Header
        {
            get;
            set;
        }

        [DataMember(Name = "tags")]
        public List<string> Tags
        {
            get;
            set;
        }
    }
}