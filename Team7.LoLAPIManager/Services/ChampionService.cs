namespace Team7.LoLAPIManager.Services
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Team7.LoLAPIManager.Core;
    using Team7.LoLAPIManager.Dto;
    using Team7.LoLAPIManager.Dto.Champion;
    using Team7.LoLAPIManager.Models;
    using Team7.LoLAPIManager.Models.Champion;

    public class ChampionService : ServiceBase
    {
        private ChampionList _allChampions;
        private Champion _champion;
        private ChampionList _freeChampions;
        private ChampionList _notFreeChampions;

        public ChampionService(LoLManagerConfig config)
            : base(config.Region, ApiVersions.V1_2, ApiEndPoints.CHAMPIONS, config.Key, true)
        {
        }

        public async Task<ChampionList> GetAsync()
        {
            if (_allChampions == null)
            {
                var champs = await WebGetAsync<ChampionListDto>(null);
                _allChampions = Mapper.Map<ChampionList>(champs);
            }

            return _allChampions;
        }

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