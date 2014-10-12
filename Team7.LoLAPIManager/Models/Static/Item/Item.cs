// <copyright file="Item.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Item
{
    using System.Collections.Generic;
    using Team7.LoLApiManager.Models.Static;

    /// <summary>
    /// Data object representing an Item.
    /// </summary>
    public class Item
    {
        public string Colloq
        {
            get;
            set;
        }

        public bool? Consumed
        {
            get;
            set;
        }

        public bool? ConsumeOnFull
        {
            get;
            set;
        }

        public int? Depth
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public List<string> From
        {
            get;
            set;
        }

        public Gold Gold
        {
            get;
            set;
        }

        public string Group
        {
            get;
            set;
        }

        public bool? HideFromAll
        {
            get;
            set;
        }

        public int? Id
        {
            get;
            set;
        }

        public Image Image
        {
            get;
            set;
        }

        public bool? InStore
        {
            get;
            set;
        }

        public List<string> Into
        {
            get;
            set;
        }

        public Dictionary<string, bool> Maps
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string PlainText
        {
            get;
            set;
        }

        public string RequiredChampion
        {
            get;
            set;
        }

        public MetaData Rune
        {
            get;
            set;
        }

        public string SanitizedDescription
        {
            get;
            set;
        }

        public int? SpecialRecipe
        {
            get;
            set;
        }

        public int? Stacks
        {
            get;
            set;
        }

        public BasicDataStats Stats
        {
            get;
            set;
        }

        public List<string> Tags
        {
            get;
            set;
        }
    }
}