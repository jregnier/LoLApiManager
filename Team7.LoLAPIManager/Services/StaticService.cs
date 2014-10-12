// <copyright file="StaticService.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Team7.LoLApiManager.Core;
    using Team7.LoLApiManager.Dto.Static;
    using Team7.LoLApiManager.Dto.Static.Champion;
    using Team7.LoLApiManager.Dto.Static.Item;
    using Team7.LoLApiManager.Models.Static;
    using Team7.LoLApiManager.Models.Static.Champion;
    using Team7.LoLApiManager.Models.Static.Item;

    /// <summary>
    /// Service class used to handle the static service.
    /// </summary>
    public class StaticService : ServiceBase
    {
        private const string relativeURL = "api/lol/{0}/{1}/{2}";

        /// <summary>
        /// Create a new instance of the <see cref="StaticService"/> service.
        /// </summary>
        /// <param name="config">
        /// A <see cref="LoLManagerConfig"/> containing the configuration information for the API.
        /// </param>
        public StaticService(LoLManagerConfig config)
            : base(config.Region, ApiVersions.V1_2, ApiEndPoints.STATIC_DATA, config.Key)
        {
        }

        /// <summary>
        /// Get a champion based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Champion to return.</param>
        /// <param name="local">
        /// Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale
        /// for the region is used.
        /// </param>
        /// <param name="dataDragonVersion">
        /// Data dragon version for returned data. If not specified, the latest version for the
        /// region is used. List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="dataById">
        /// If specified as true, the returned data map will use the champions' IDs as the keys. If
        /// not specified or specified as false, the returned data map will use the champions' keys instead.
        /// </param>
        /// <param name="champData">
        /// Tags to return additional data. Only type, version, data, id, key, name, and title are
        /// returned by default if this parameter isn't specified. To return all additional data,
        /// use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="Champion"/> for the given ID.</returns>
        public async Task<Champion> GetChampionAsync(
            int id,
            string local = null,
            string dataDragonVersion = null,
            bool? dataById = null,
            List<ApiChampionData> champData = null)
        {
            string urlString = string.Format("/champion/{0}", id);

            List<string> queryItems = new List<string>();

            if (!string.IsNullOrEmpty(local))
            {
                queryItems.Add(string.Format("local={1}", local));
            }

            if (!string.IsNullOrEmpty(dataDragonVersion))
            {
                queryItems.Add(string.Format("version={0}", dataDragonVersion));
            }

            if (dataById.HasValue)
            {
                queryItems.Add(string.Format("dataById={0}", dataById.Value));
            }

            if (champData != null && champData.Count > 0)
            {
                var dataStrings = ChampionData.GetChampionData
                                    .Where(d => champData.Contains(d.Key))
                                    .Select(v => v.Value)
                                    .ToList();

                queryItems.Add(string.Format("champData={0}", string.Join(",", dataStrings)));
            }

            if (queryItems.Count > 0)
            {
                urlString += string.Format("?{0}", string.Join("&", queryItems));
            }

            var uri = new Uri(urlString, UriKind.Relative);

            var champDto = await WebGetAsync<ChampionDto>(uri);

            var champ = Mapper.Map<Champion>(champDto);

            return champ;
        }

        /// <summary>
        /// Get all champions.
        /// </summary>
        /// <param name="local">
        /// Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale
        /// for the region is used.
        /// </param>
        /// <param name="dataDragonVersion">
        /// Data dragon version for returned data. If not specified, the latest version for the
        /// region is used. List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="dataById">
        /// If specified as true, the returned data map will use the champions' IDs as the keys. If
        /// not specified or specified as false, the returned data map will use the champions' keys instead.
        /// </param>
        /// <param name="champData">
        /// Tags to return additional data. Only type, version, data, id, key, name, and title are
        /// returned by default if this parameter isn't specified. To return all additional data,
        /// use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="ChampionList"/> containing data for all champions.</returns>
        public async Task<ChampionList> GetChampionsAsync(
            string local = null,
            string dataDragonVersion = null,
            bool? dataById = null,
            List<ApiChampionData> champData = null)
        {
            string urlString = "/champion";

            List<string> queryItems = new List<string>();

            if (!string.IsNullOrEmpty(local))
            {
                queryItems.Add(string.Format("local={1}", local));
            }

            if (!string.IsNullOrEmpty(dataDragonVersion))
            {
                queryItems.Add(string.Format("version={0}", dataDragonVersion));
            }

            if (dataById.HasValue)
            {
                queryItems.Add(string.Format("dataById={0}", dataById.Value));
            }

            if (champData != null && champData.Count > 0)
            {
                var dataStrings = ChampionData.GetChampionData
                                    .Where(d => champData.Contains(d.Key))
                                    .Select(v => v.Value)
                                    .ToList();

                queryItems.Add(string.Format("champData={0}", string.Join(",", dataStrings)));
            }

            if (queryItems.Count > 0)
            {
                urlString += string.Format("?{0}", string.Join("&", queryItems));
            }

            var uri = new Uri(urlString, UriKind.Relative);

            var champsDto = await WebGetAsync<ChampionListDto>(uri);

            var champs = Mapper.Map<ChampionList>(champsDto);

            return champs;
        }

        /// <summary>
        /// Get an item based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Item to return.</param>
        /// <param name="local">
        /// Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale
        /// for the region is used.
        /// </param>
        /// <param name="dataDragonVersion">
        /// Data dragon version for returned data. If not specified, the latest version for the
        /// region is used. List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="itemListData">
        /// Tags to return additional data. Only type, version, basic, data, id, name, plaintext,
        /// group, and description are returned by default if this parameter isn't specified. To
        /// return all additional data, use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="Item"/> for the given ID.</returns>
        public async Task<Item> GetItemAsync(
            int id,
            string local = null,
            string dataDragonVersion = null,
            List<ApiItemData> itemData = null)
        {
            string urlString = string.Format("/item/{0}", id);

            List<string> queryItems = new List<string>();

            if (!string.IsNullOrEmpty(local))
            {
                queryItems.Add(string.Format("local={1}", local));
            }

            if (!string.IsNullOrEmpty(dataDragonVersion))
            {
                queryItems.Add(string.Format("version={0}", dataDragonVersion));
            }

            if (itemData != null && itemData.Count > 0)
            {
                var dataStrings = ItemData.GetItemData
                                    .Where(d => itemData.Contains(d.Key))
                                    .Select(v => v.Value)
                                    .ToList();

                queryItems.Add(string.Format("itemData={0}", string.Join(",", dataStrings)));
            }

            if (queryItems.Count > 0)
            {
                urlString += string.Format("?{0}", string.Join("&", queryItems));
            }

            var uri = new Uri(urlString, UriKind.Relative);

            var itemDto = await WebGetAsync<ItemDto>(uri);

            var item = Mapper.Map<Item>(itemDto);

            return item;
        }

        /// <summary>
        /// Get all items.
        /// </summary>
        /// <param name="local">
        /// Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale
        /// for the region is used.
        /// </param>
        /// <param name="dataDragonVersion">
        /// Data dragon version for returned data. If not specified, the latest version for the
        /// region is used. List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="itemListData">
        /// Tags to return additional data. Only type, version, basic, data, id, name, plaintext,
        /// group, and description are returned by default if this parameter isn't specified. To
        /// return all additional data, use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="Item"/> for the given ID.</returns>
        public async Task<ItemList> GetItemsAsync(
            string local = null,
            string dataDragonVersion = null,
            List<ApiItemListData> itemListData = null)
        {
            string urlString = "/item";

            List<string> queryItems = new List<string>();

            if (!string.IsNullOrEmpty(local))
            {
                queryItems.Add(string.Format("local={1}", local));
            }

            if (!string.IsNullOrEmpty(dataDragonVersion))
            {
                queryItems.Add(string.Format("version={0}", dataDragonVersion));
            }

            if (itemListData != null && itemListData.Count > 0)
            {
                var dataStrings = ItemListData.GetItemListData
                                    .Where(d => itemListData.Contains(d.Key))
                                    .Select(v => v.Value)
                                    .ToList();

                queryItems.Add(string.Format("itemListData={0}", string.Join(",", dataStrings)));
            }

            if (queryItems.Count > 0)
            {
                urlString += string.Format("?{0}", string.Join("&", queryItems));
            }

            var uri = new Uri(urlString, UriKind.Relative);

            var itemsDto = await WebGetAsync<ItemListDto>(uri);

            var items = Mapper.Map<ItemList>(itemsDto);

            return items;
        }

        protected override Uri BuildRelativeUri()
        {
            var relativeUri = new Uri(string.Format(relativeURL, EndPoints.GetEndPoints[EndPoint], Regions.GetRegions[Region], Versions.GetVersions[Version]), UriKind.Relative);

            return relativeUri;
        }

        protected override void CreateMapping()
        {
            //Common Mapping
            Mapper.CreateMap<ImageDto, Image>();

            // Champion mappings
            Mapper.CreateMap<ChampionListDto, ChampionList>();
            Mapper.CreateMap<ChampionDto, Champion>();
            Mapper.CreateMap<ChampionSpellDto, ChampionSpell>();
            Mapper.CreateMap<InfoDto, Info>();
            Mapper.CreateMap<PassiveDto, Passive>();
            Mapper.CreateMap<RecommendedDto, Recommended>();
            Mapper.CreateMap<SkinDto, Skin>();
            Mapper.CreateMap<StatsDto, Stats>();
            Mapper.CreateMap<LevelTipDto, LevelTip>();
            Mapper.CreateMap<SpellVarsDto, SpellVars>();
            Mapper.CreateMap<BlockDto, Block>();
            Mapper.CreateMap<BlockItem, BlockItem>();

            // Item Mappings
            Mapper.CreateMap<ItemListDto, ItemList>();
            Mapper.CreateMap<BasicDataDto, BasicData>();
            Mapper.CreateMap<GroupDto, Group>();
            Mapper.CreateMap<ItemDto, Item>();
            Mapper.CreateMap<ItemTreeDto, ItemTree>();
            Mapper.CreateMap<BasicDataStatsDto, BasicDataStats>();
            Mapper.CreateMap<GoldDto, Gold>();
            Mapper.CreateMap<MetaDataDto, MetaData>();
        }
    }
}