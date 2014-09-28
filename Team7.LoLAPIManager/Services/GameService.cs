// <copyright file="GameService.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLAPIManager.Services
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Team7.LoLAPIManager.Core;
    using Team7.LoLAPIManager.Dto.Game;
    using Team7.LoLAPIManager.Models.Game;

    /// <summary>
    /// Service class used to handle the Game service.
    /// </summary>
    public class GameService : ServiceBase
    {
        private RecentGames _recentGames;

        /// <summary>
        /// Create a new instance of the <see cref="GameService"/> service.
        /// </summary>
        /// <param name="config">
        /// A <see cref="LoLManagerConfig"/> containing the configuration information for the API.
        /// </param>
        public GameService(LoLManagerConfig config)
            : base(config.Region, ApiVersions.V1_3, ApiEndPoints.GAME, config.Key, true)
        {
        }

        /// <summary>
        /// Get the recent games for a given summoner (Only gets the last 10 games).
        /// </summary>
        /// <param name="summonerId">The summoner ID for a given player</param>
        /// <returns>A <see cref="RecentGame"/> object with the game data.</returns>
        public async Task<RecentGames> GetAsync(int summonerId)
        {
            var uri = new Uri(string.Format("/by-summoner/{0}/recent", summonerId), UriKind.Relative);

            var gamesDto = await WebGetAsync<RecentGamesDto>(uri);

            var games = Mapper.Map<RecentGames>(gamesDto);

            return games;
        }

        protected override void CreateMapping()
        {
            Mapper.CreateMap<RecentGamesDto, RecentGames>();
            Mapper.CreateMap<GameDto, Game>();
            Mapper.CreateMap<PlayerDto, Player>();
            Mapper.CreateMap<RawStatsDto, RawStats>();
        }
    }
}