// <copyright file="GroupDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Item
{
    using System.Runtime.Serialization;

    [DataContract]
    public class GroupDto
    {
        [DataMember(Name = "key")]
        public string Key
        {
            get;
            set;
        }

        [DataMember(Name = "MaxGroupOwnable")]
        public string MaxGroupOwnable
        {
            get;
            set;
        }
    }
}