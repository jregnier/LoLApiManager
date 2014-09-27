namespace Team7.LoLAPIManager.Services
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Team7.LoLAPIManager.Core;
    using Team7.LoLAPIManager.Dto.Game;
    using Team7.LoLAPIManager.Models.Game;

    public class GameService : ServiceBase
    {
        private RecentGames _recentGames;

        public GameService(LoLManagerConfig config)
            : base(config.Region, ApiVersions.V1_3, ApiEndPoints.GAME, config.Key, true)
        {
        }

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