// <copyright file="LeagueService.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Team7.LoLApiManager.Core;
    using Team7.LoLApiManager.Dto.League;
    using Team7.LoLApiManager.Models.League;

    /// <summary>
    /// Service class used to handle the League service.
    /// </summary>
    public class LeagueService : ServiceBase
    {
        /// <summary>
        /// Create a new instance of the <see cref="LeagueService"/> service.
        /// </summary>
        /// <param name="config">
        /// A <see cref="LoLManagerConfig"/> containing the configuration information for the API.
        /// </param>
        public LeagueService(LoLManagerConfig config)
            : base(config.Region, ApiVersions.V2_5, ApiEndPoints.LEAGUE, config.Key)
        {
        }

        /// <summary>
        /// Get leagues mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="summonerIds">The list of summoner Ids.</param>
        /// <returns>A Dictionary of league for all Ids</returns>
        public async Task<Dictionary<string, List<League>>> GetBySummonerIdAsync(List<int> summonerIds)
        {
            if (summonerIds == null)
            {
                throw new ArgumentNullException("summonerIds");
            }
            else if (summonerIds.Count > 10)
            {
                throw new ArgumentException("Only 10 summoner Ids can be included in the call");
            }

            var uri = new Uri(string.Format("/by-summoner/{0}", summonerIds.ToCommaDelimited()), UriKind.Relative);

            var leaguesDto = await WebGetAsync<Dictionary<string, List<LeagueDto>>>(uri);

            var games = Mapper.Map<Dictionary<string, List<League>>>(leaguesDto);

            return games;
        }

        /// <summary>
        /// Get leagues mapped by team ID for a given list of team IDs.
        /// </summary>
        /// <param name="teamIds">The list of team Ids.</param>
        /// <returns>A Dictionary of league for all Ids</returns>
        public async Task<Dictionary<string, List<League>>> GetByTeamIdAsync(List<int> teamIds)
        {
            if (teamIds == null)
            {
                throw new ArgumentNullException("summonerIds");
            }
            else if (teamIds.Count > 10)
            {
                throw new ArgumentException("Only 10 teamIds Ids can be included in the call");
            }

            var uri = new Uri(string.Format("/by-team/{0}", teamIds.ToCommaDelimited()), UriKind.Relative);

            var leagueEntriesDto = await WebGetAsync<Dictionary<string, List<LeagueDto>>>(uri);

            var leagueEntries = Mapper.Map<Dictionary<string, List<League>>>(leagueEntriesDto);

            return leagueEntries;
        }

        /// <summary>
        /// Get challenger tier leagues.
        /// </summary>
        /// <param name="teamIds">The list of team Ids.</param>
        /// <returns>A Dictionary of league for all Ids</returns>
        public async Task<League> GetChallengerTierLeagueAsync(ApiGameQueueTypes gameQueueType)
        {
            var uri = new Uri(string.Format("/challenger?type={0}", GameQueueTypes.GetGameQueueTypes[gameQueueType]), UriKind.Relative);

            var leagueEntryDto = await WebGetAsync<LeagueDto>(uri);

            var leagueEntry = Mapper.Map<League>(leagueEntryDto);

            return leagueEntry;
        }

        /// <summary>
        /// Get league entries mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="summonerIds">The list of summoner Ids.</param>
        /// <returns>A Dictionary of league for all Ids</returns>
        public async Task<Dictionary<string, List<League>>> GetEntriesBySummonerIdAsync(List<int> summonerIds)
        {
            if (summonerIds == null)
            {
                throw new ArgumentNullException("summonerIds");
            }
            else if (summonerIds.Count > 10)
            {
                throw new ArgumentException("Only 10 summoner Ids can be included in the call");
            }

            var uri = new Uri(string.Format("/by-summoner/{0}/entry", summonerIds.ToCommaDelimited()), UriKind.Relative);

            var leagueEntriesDto = await WebGetAsync<Dictionary<string, List<LeagueDto>>>(uri);

            var leagueEntries = Mapper.Map<Dictionary<string, List<League>>>(leagueEntriesDto);

            return leagueEntries;
        }

        /// <summary>
        /// Get league entries mapped by team ID for a given list of team IDs.
        /// </summary>
        /// <param name="teamIds">The list of team Ids.</param>
        /// <returns>A Dictionary of league for all Ids</returns>
        public async Task<Dictionary<string, List<League>>> GetEntriesByTeamIdAsync(List<int> teamIds)
        {
            if (teamIds == null)
            {
                throw new ArgumentNullException("summonerIds");
            }
            else if (teamIds.Count > 10)
            {
                throw new ArgumentException("Only 10 teamIds Ids can be included in the call");
            }

            var uri = new Uri(string.Format("/by-team/{0}/entry", teamIds.ToCommaDelimited()), UriKind.Relative);

            var leagueEntriesDto = await WebGetAsync<Dictionary<string, List<LeagueDto>>>(uri);

            var leagueEntries = Mapper.Map<Dictionary<string, List<League>>>(leagueEntriesDto);

            return leagueEntries;
        }

        protected override void CreateMapping()
        {
            Mapper.CreateMap<LeagueDto, League>();
            Mapper.CreateMap<LeagueEntryDto, LeagueEntry>();
            Mapper.CreateMap<MiniSeriesDto, MiniSeries>();
        }
    }
}