// <copyright file="Gold.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Static.Item
{
    /// <summary>
    /// Data object representing gold for an item.
    /// </summary>
    public class Gold
    {
        public int Base
        {
            get;
            set;
        }

        public bool Purchasable
        {
            get;
            set;
        }

        public int Sell
        {
            get;
            set;
        }

        public int Total
        {
            get;
            set;
        }
    }
}