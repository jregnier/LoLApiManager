// <copyright file="BlockDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class BlockDto
    {
        [DataMember(Name = "items")]
        public List<BlockItemDto> Items
        {
            get;
            set;
        }

        [DataMember(Name = "recMath")]
        public bool RecMath
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