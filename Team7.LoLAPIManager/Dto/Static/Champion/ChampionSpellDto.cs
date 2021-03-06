﻿// <copyright file="ChampionSpellDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Champion
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ChampionSpellDto
    {
        [DataMember(Name = "altimage")]
        public List<ImageDto> Altimages
        {
            get;
            set;
        }

        [DataMember(Name = "cooldown")]
        public List<double> Cooldown
        {
            get;
            set;
        }

        [DataMember(Name = "cooldownBurn")]
        public string CooldownBurn
        {
            get;
            set;
        }

        [DataMember(Name = "cost")]
        public List<int> Cost
        {
            get;
            set;
        }

        [DataMember(Name = "costBurn")]
        public string CostBurn
        {
            get;
            set;
        }

        [DataMember(Name = "costType")]
        public string CostType
        {
            get;
            set;
        }

        [DataMember(Name = "description")]
        public string Description
        {
            get;
            set;
        }

        [DataMember(Name = "effect")]
        public List<List<double>> Effect
        {
            get;
            set;
        }

        [DataMember(Name = "effectBurn")]
        public List<string> EffectBurn
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

        [DataMember(Name = "key")]
        public string Key
        {
            get;
            set;
        }

        [DataMember(Name = "leveltip")]
        public LevelTipDto Leveltip
        {
            get;
            set;
        }

        [DataMember(Name = "maxrank")]
        public int Maxrank
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

        [DataMember(Name = "range")]
        public object Range
        {
            get;
            set;
        }

        [DataMember(Name = "rangeBurn")]
        public string RangeBurn
        {
            get;
            set;
        }

        [DataMember(Name = "resource")]
        public string Resource
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

        [DataMember(Name = "sanitizedTooltip")]
        public string SanitizedTooltip
        {
            get;
            set;
        }

        [DataMember(Name = "tooltip")]
        public string Tooltip
        {
            get;
            set;
        }

        [DataMember(Name = "vars")]
        public List<SpellVarsDto> Vars
        {
            get;
            set;
        }
    }
}