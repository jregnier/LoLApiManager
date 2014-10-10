// <copyright file="StatsDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Runtime.Serialization;

    [DataContract]
    public class StatsDto
    {
        [DataMember(Name = "armor")]
        public double Armor
        {
            get;
            set;
        }

        [DataMember(Name = "armorperlevel")]
        public double Armorperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "attackdamage")]
        public double Attackdamage
        {
            get;
            set;
        }

        [DataMember(Name = "attackdamageperlevel")]
        public double Attackdamageperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "attackrange")]
        public double Attackrange
        {
            get;
            set;
        }

        [DataMember(Name = "attackspeedoffset")]
        public double Attackspeedoffset
        {
            get;
            set;
        }

        [DataMember(Name = "attackspeedperlevel")]
        public double Attackspeedperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "crit")]
        public double Crit
        {
            get;
            set;
        }

        [DataMember(Name = "critperlevel")]
        public double Critperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "hp")]
        public double Hp
        {
            get;
            set;
        }

        [DataMember(Name = "hpperlevel")]
        public double Hpperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "hpregen")]
        public double Hpregen
        {
            get;
            set;
        }

        [DataMember(Name = "hpregenperlevel")]
        public double Hpregenperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "movespeed")]
        public double Movespeed
        {
            get;
            set;
        }

        [DataMember(Name = "mp")]
        public double Mp
        {
            get;
            set;
        }

        [DataMember(Name = "mpperlevel")]
        public double Mpperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "mpregen")]
        public double Mpregen
        {
            get;
            set;
        }

        [DataMember(Name = "mpregenperlevel")]
        public double Mpregenperlevel
        {
            get;
            set;
        }

        [DataMember(Name = "spellblock")]
        public double Spellblock
        {
            get;
            set;
        }

        [DataMember(Name = "spellblockperlevel")]
        public double Spellblockperlevel
        {
            get;
            set;
        }
    }
}