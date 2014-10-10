// <copyright file="ChampionSpell.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing a champions spell.
    /// </summary>
    public class ChampionSpell
    {
        public List<Image> Altimages
        {
            get;
            set;
        }

        public List<double> Cooldown
        {
            get;
            set;
        }

        public string CooldownBurn
        {
            get;
            set;
        }

        public List<int> Cost
        {
            get;
            set;
        }

        public string CostBurn
        {
            get;
            set;
        }

        public string CostType
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public List<List<double>> Effect
        {
            get;
            set;
        }

        public List<string> EffectBurn
        {
            get;
            set;
        }

        public Image Image
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }

        public LevelTip Leveltip
        {
            get;
            set;
        }

        public int Maxrank
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public object Range
        {
            get;
            set;
        }

        public string RangeBurn
        {
            get;
            set;
        }

        public string Resource
        {
            get;
            set;
        }

        public string SanitizedDescription
        {
            get;
            set;
        }

        public string SanitizedTooltip
        {
            get;
            set;
        }

        public string Tooltip
        {
            get;
            set;
        }

        public List<SpellVars> Vars
        {
            get;
            set;
        }
    }
}