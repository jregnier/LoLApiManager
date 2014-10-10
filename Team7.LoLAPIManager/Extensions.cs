// <copyright file="Extensions.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static DateTime EpochToDateTime(this long epochDate)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(epochDate);
        }

        public static string ToCommaDelimited(this List<int> list)
        {
            return string.Join<int>(",", list);
        }
    }
}