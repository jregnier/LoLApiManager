// <copyright file="LevelTip.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class LevelTipDto
    {
        [DataMember(Name = "effect")]
        public List<string> Effect
        {
            get;
            set;
        }

        [DataMember(Name = "label")]
        public List<string> Label
        {
            get;
            set;
        }
    }
}