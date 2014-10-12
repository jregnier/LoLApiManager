// <copyright file="ImageDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ImageDto
    {
        [DataMember(Name = "full")]
        public string Full
        {
            get;
            set;
        }

        [DataMember(Name = "group")]
        public string Group
        {
            get;
            set;
        }

        [DataMember(Name = "h")]
        public int H
        {
            get;
            set;
        }

        [DataMember(Name = "sprite")]
        public string Sprite
        {
            get;
            set;
        }

        [DataMember(Name = "w")]
        public int W
        {
            get;
            set;
        }

        [DataMember(Name = "x")]
        public int X
        {
            get;
            set;
        }

        [DataMember(Name = "y")]
        public int Y
        {
            get;
            set;
        }
    }
}