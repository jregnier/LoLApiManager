// <copyright file="GoldDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Item
{
    using System.Runtime.Serialization;

    [DataContract]
    public class GoldDto
    {
        [DataMember(Name = "base")]
        public int Base
        {
            get;
            set;
        }

        [DataMember(Name = "purchasable")]
        public bool Purchasable
        {
            get;
            set;
        }

        [DataMember(Name = "sell")]
        public int Sell
        {
            get;
            set;
        }

        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }
    }
}