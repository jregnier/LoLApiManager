// <copyright file="Passive.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    /// <summary>
    /// Data object representing the passive of a champion.
    /// </summary>
    public class Passive
    {
        public string Description
        {
            get;
            set;
        }

        public Image Image
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string SanitizedDescription
        {
            get;
            set;
        }
    }
}