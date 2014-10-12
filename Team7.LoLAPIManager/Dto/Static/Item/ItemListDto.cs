// <copyright file="ItemListDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Item
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ItemListDto
    {
        [DataMember(Name = "basic")]
        public BasicDataDto Basic
        {
            get;
            set;
        }

        [DataMember(Name = "data")]
        public Dictionary<string, ItemDto> Data
        {
            get;
            set;
        }

        [DataMember(Name = "groups")]
        public List<GroupDto> Groups
        {
            get;
            set;
        }

        [DataMember(Name = "tree")]
        public List<ItemTreeDto> Tree
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