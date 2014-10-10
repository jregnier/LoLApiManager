// <copyright file="BlockItemDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Runtime.Serialization;

    [DataContract]
    public class BlockItemDto
    {
        [DataMember(Name = "count")]
        public int Count
        {
            get;
            set;
        }

        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }
    }
}