// <copyright file="PassiveDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Runtime.Serialization;

    [DataContract]
    public class PassiveDto
    {
        [DataMember(Name = "description")]
        public string Description
        {
            get;
            set;
        }

        [DataMember(Name = "image")]
        public ImageDto Image
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

        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription
        {
            get;
            set;
        }
    }
}