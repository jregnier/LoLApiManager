// <copyright file="MiniSeries.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Dto.League
{
    using System.Runtime.Serialization;

    [DataContract]
    public class MiniSeriesDto
    {
        [DataMember(Name = "losses")]
        public int Losses
        {
            get;
            set;
        }

        [DataMember(Name = "progress")]
        public string Progress
        {
            get;
            set;
        }

        [DataMember(Name = "target")]
        public int Target
        {
            get;
            set;
        }

        [DataMember(Name = "wins")]
        public int Wins
        {
            get;
            set;
        }
    }
}