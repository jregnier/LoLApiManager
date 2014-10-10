// <copyright file="Skin.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Champion
{
    /// <summary>
    /// Data object representing a champion skin.
    /// </summary>
    public class Skin
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Num
        {
            get;
            set;
        }
    }
}