// <copyright file="SpellVarsDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class SpellVarsDto
    {
        [DataMember(Name = "coeff")]
        public List<double> Coeff
        {
            get;
            set;
        }

        [DataMember(Name = "dyn")]
        public string Dyn
        {
            get;
            set;
        }

        [DataMember(Name = "key")]
        public string Key
        {
            get;
            set;
        }

        [DataMember(Name = "link")]
        public string Link
        {
            get;
            set;
        }

        [DataMember(Name = "ranksWith")]
        public string RanksWith
        {
            get;
            set;
        }
    }
}