// <copyright file="LoLManager.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager
{
    using System;
    using Team7.LoLAPIManager.Core;
    using Team7.LoLAPIManager.Services;

    public class LoLManager
    {
        #region SingleTon

        private static LoLManager _instance;
        private bool _isInitialized;

        public static LoLManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoLManager();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Initialize the singleton instance of the <see cref="LoLManager"/> Class
        /// </summary>
        /// <param name="config">The configuration objects holding all the configuration properties</param>
        public void Initialize(LoLManagerConfig config)
        {
            if (_isInitialized)
            {
                return;
            }

            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            _configuration = config;

            _isInitialized = true;
        }

        /// <summary>
        /// Initialize the singleton instance of the <see cref="LoLManager"/> Class
        /// </summary>
        /// <param name="key">The Api key for the application received by Riot</param>
        /// <param name="region">The region of the Api Key</param>
        public void Initialize(string key, ApiRegions region)
        {
            if (_isInitialized)
            {
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            _configuration = new LoLManagerConfig(key, region);

            _isInitialized = true;
        }

        #endregion SingleTon

        private ChampionService _champion;
        private LoLManagerConfig _configuration;
        private GameService _game;
        private LeagueService _league;

        public LoLManagerConfig Configuration
        {
            get
            {
                return _configuration;
            }

            private set
            {
                _configuration = value;
            }
        }

        #region Public Interface

        public ChampionService Champion
        {
            get
            {
                if (_champion == null)
                {
                    _champion = new ChampionService(_configuration);
                }

                return _champion;
            }
        }

        public GameService Game
        {
            get
            {
                if (_game == null)
                {
                    _game = new GameService(_configuration);
                }

                return _game;
            }
        }

        public LeagueService League
        {
            get
            {
                if (_league == null)
                {
                    _league = new LeagueService(_configuration);
                }

                return _league;
            }
        }

        #endregion Public Interface
    }
}