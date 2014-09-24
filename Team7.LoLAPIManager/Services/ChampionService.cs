
namespace Team7.LoLAPIManager.Services
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Team7.LoLAPIManager.Core;
    using Team7.LoLAPIManager.Dto;
    using Team7.LoLAPIManager.Models;

    public class ChampionService : ServiceBase
    {
        private ChampionList _allChampions;
        private ChampionList _freeChampions;
        private ChampionList _notFreeChampions;
        private Champion _champion;

        public ChampionService(LoLManagerConfig config)
            : base(config.Region, ApiVersions.V1_2, ApiEndPoints.CHAMPIONS, config.Key, true)
        {
        }

        public async Task<ChampionList> GetAsync()
        {
            if (_allChampions == null)
            {
                var champs = await WebGetAsync<ChampionListDto>(new Uri("champion", UriKind.Relative));
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
                    var champs = await WebGetAsync<ChampionListDto>(new Uri("champion?freeToPlay=true", UriKind.Relative));
                    _freeChampions = Mapper.Map<ChampionList>(champs);
                }

                return _freeChampions;
            }
            else
            {
                if (_notFreeChampions == null)
                {
                    var champs = await WebGetAsync<ChampionListDto>(new Uri("champion?freeToPlay=false", UriKind.Relative));
                    _notFreeChampions = Mapper.Map<ChampionList>(champs);
                }

                return _notFreeChampions;
            }
        }

        public async Task<Champion> GetAsync(int id)
        {
            var champ = await WebGetAsync<ChampionDto>(new Uri(string.Format("champion/{0}", id), UriKind.Relative));
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
