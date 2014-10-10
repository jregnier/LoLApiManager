// <copyright file="SkinDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Runtime.Serialization;

    [DataContract]
    public class SkinDto
    {
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Name = "num")]
        public int Num
        {
            get;
            set;
        }
    }
}