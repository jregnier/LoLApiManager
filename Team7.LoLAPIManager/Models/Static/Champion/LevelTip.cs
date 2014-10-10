// <copyright file="LevelTip.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    using System.Collections.Generic;

    /// <summary>
    /// Data object representing a LevelTip.
    /// </summary>
    public class LevelTip
    {
        public List<string> Effect
        {
            get;
            set;
        }

        public List<string> Label
        {
            get;
            set;
        }
    }
}