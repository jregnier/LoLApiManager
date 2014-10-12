// <copyright file="MetaData.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Item
{
    /// <summary>
    /// Data object representing a meta data for an item.
    /// </summary>
    public class MetaData
    {
        public bool IsRune
        {
            get;
            set;
        }

        public string Tier
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }
    }
}