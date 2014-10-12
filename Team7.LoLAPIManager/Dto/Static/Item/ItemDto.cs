// <copyright file="ItemDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Static.Item
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Team7.LoLApiManager.Dto.Static;

    [DataContract]
    public class ItemDto
    {
        [DataMember(Name = "colloq")]
        public string Colloq
        {
            get;
            set;
        }

        [DataMember(Name = "consumed")]
        public bool? Consumed
        {
            get;
            set;
        }

        [DataMember(Name = "consumeOnFull")]
        public bool? ConsumeOnFull
        {
            get;
            set;
        }

        [DataMember(Name = "depth")]
        public int? Depth
        {
            get;
            set;
        }

        [DataMember(Name = "description")]
        public string Description
        {
            get;
            set;
        }

        [DataMember(Name = "from")]
        public List<string> From
        {
            get;
            set;
        }

        [DataMember(Name = "gold")]
        public GoldDto Gold
        {
            get;
            set;
        }

        [DataMember(Name = "group")]
        public string Group
        {
            get;
            set;
        }

        [DataMember(Name = "hideFromAll")]
        public bool? HideFromAll
        {
            get;
            set;
        }

        [DataMember(Name = "id")]
        public int? Id
        {
            get;
            set;
        }

        [DataMember(Name = "image")]
        public ImageDto Image
        {
            get;
            set;
        }

        [DataMember(Name = "inStore")]
        public bool? InStore
        {
            get;
            set;
        }

        [DataMember(Name = "into")]
        public List<string> Into
        {
            get;
            set;
        }

        [DataMember(Name = "maps")]
        public Dictionary<string, bool> Maps
        {
            get;
            set;
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Name = "plaintext")]
        public string PlainText
        {
            get;
            set;
        }

        [DataMember(Name = "requiredChampion")]
        public string RequiredChampion
        {
            get;
            set;
        }

        [DataMember(Name = "rune")]
        public MetaDataDto Rune
        {
            get;
            set;
        }

        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription
        {
            get;
            set;
        }

        [DataMember(Name = "specialRecipe")]
        public int? SpecialRecipe
        {
            get;
            set;
        }

        [DataMember(Name = "stacks")]
        public int? Stacks
        {
            get;
            set;
        }

        [DataMember(Name = "stats")]
        public BasicDataStatsDto Stats
        {
            get;
            set;
        }

        [DataMember(Name = "tags")]
        public List<string> Tags
        {
            get;
            set;
        }
    }
}