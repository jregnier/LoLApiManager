// <copyright file="InfoDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Runtime.Serialization;

    [DataContract]
    public class InfoDto
    {
        [DataMember(Name = "attack")]
        public int Attack
        {
            get;
            set;
        }

        [DataMember(Name = "defense")]
        public int Defense
        {
            get;
            set;
        }

        [DataMember(Name = "difficulty")]
        public int Difficulty
        {
            get;
            set;
        }

        [DataMember(Name = "magic")]
        public int Magic
        {
            get;
            set;
        }
    }
}