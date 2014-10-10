// <copyright file="Champion.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing a champion in the game.
    /// </summary>
    public class Champion
    {
        public List<string> Allytips
        {
            get;
            set;
        }

        public string Blurb
        {
            get;
            set;
        }

        public List<string> Enemytips
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public Image Image
        {
            get;
            set;
        }

        public Info Info
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }

        public string Lore
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Partype
        {
            get;
            set;
        }

        public Passive Passive
        {
            get;
            set;
        }

        public List<Recommended> Recommended
        {
            get;
            set;
        }

        public List<Skin> Skins
        {
            get;
            set;
        }

        public List<ChampionSpell> Spells
        {
            get;
            set;
        }

        public Stats Stats
        {
            get;
            set;
        }

        public List<string> Tags
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }
    }
}