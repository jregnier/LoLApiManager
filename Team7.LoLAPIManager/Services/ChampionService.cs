// <copyright file="ChampionService.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Services
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Team7.LoLApiManager.Core;
    using Team7.LoLApiManager.Dto;
    using Team7.LoLApiManager.Dto.Champion;
    using Team7.LoLApiManager.Models;
    using Team7.LoLApiManager.Models.Champion;

    /// <summary>
    /// Service class used to handle the Champion service.
    /// </summary>
    public class ChampionService : ServiceBase
    {
        private ChampionList _allChampions;
        private Champion _champion;
        private ChampionList _freeChampions;
        private ChampionList _notFreeChampions;

        /// <summary>
        /// Create a new instance of the <see cref="ChampionService"/> service.
        /// </summary>
        /// <param name="config">
        /// A <see cref="LoLManagerConfig"/> containing the configuration information for the API.
        /// </param>
        public ChampionService(LoLManagerConfig config)
            : base(config.Region, ApiVersions.V1_2, ApiEndPoints.CHAMPIONS, config.Key)
        {
        }

        /// <summary>
        /// Gets all champions in the game.
        /// </summary>
        /// <returns>A <see cref="ChampionList"/> that holds all champions</returns>
        public async Task<ChampionList> GetAsync()
        {
            if (_allChampions == null)
            {
                var champs = await WebGetAsync<ChampionListDto>(null);
                _allChampions = Mapper.Map<ChampionList>(champs);
            }

            return _allChampions;
        }

        /// <summary>
        /// Get the free to play or the not free champions.
        /// </summary>
        /// <param name="freeToPlay">
        /// True if all the free champions should be returned. OPtherwise false to return the not
        /// free champions.
        /// </param>
        /// <returns>A <see cref="ChampionList"/> that holds the champions requested</returns>
        public async Task<ChampionList> GetAsync(bool freeToPlay)
        {
            if (freeToPlay)
            {
                if (_freeChampions == null)
                {
                    var champs = await WebGetAsync<ChampionListDto>(new Uri("?freeToPlay=true", UriKind.Relative));
                    _freeChampions = Mapper.Map<ChampionList>(champs);
                }

                return _freeChampions;
            }
            else
            {
                if (_notFreeChampions == null)
                {
                    var champs = await WebGetAsync<ChampionListDto>(new Uri("?freeToPlay=false", UriKind.Relative));
                    _notFreeChampions = Mapper.Map<ChampionList>(champs);
                }

                return _notFreeChampions;
            }
        }

        /// <summary>
        /// Get a specific <see cref="Champion"/> by ID.
        /// </summary>
        /// <param name="id">The ID of the champion</param>
        /// <returns>The <see cref="Champion"/> that represents the ID passed in</returns>
        public async Task<Champion> GetAsync(int id)
        {
            var champ = await WebGetAsync<ChampionDto>(new Uri(string.Format("/{0}", id), UriKind.Relative));
            _champion = Mapper.Map<Champion>(champ);

            return _champion;
        }

        protected override void CreateMapping()
        {
            Mapper.CreateMap<ChampionListDto, ChampionList>();
            Mapper.CreateMap<ChampionDto, Champion>();
        }
    }
}