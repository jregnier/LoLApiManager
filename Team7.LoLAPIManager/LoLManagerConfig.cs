// <copyright file="LoLManagerConfig.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager
{
    using System;
    using Team7.LoLAPIManager.Core;

    /// <summary>
    /// Object holding the configuration properties needed to communicate with the Riot API.
    /// </summary>
    public class LoLManagerConfig
    {
        /// <summary>
        /// Create a new instance of the <see cref="LoLManagerConfig"/> Class.
        /// </summary>
        /// <param name="key">The Api key for the application received by Riot</param>
        /// <param name="region">The region of the Api Key</param>
        public LoLManagerConfig(string key, ApiRegions region)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            this.Key = key;
            this.Region = region;

            //TODO: Add a configuration to keep X amount of service calls in memory
        }

        public string Key { get; set; }

        public ApiRegions Region { get; set; }

        public string RegionString { get { return Regions.GetRegions[Region]; } }
    }
}