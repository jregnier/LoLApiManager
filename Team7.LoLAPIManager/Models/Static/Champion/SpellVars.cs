// <copyright file="SpellVars.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing a SpellVars.
    /// </summary>
    public class SpellVars
    {
        public List<double> Coeff
        {
            get;
            set;
        }

        public string Dyn
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }

        public string Link
        {
            get;
            set;
        }

        public string RanksWith
        {
            get;
            set;
        }
    }
}