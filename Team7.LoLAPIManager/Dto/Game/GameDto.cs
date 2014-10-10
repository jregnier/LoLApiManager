// <copyright file="GameDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Game
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class GameDto
    {
        [DataMember(Name = "championId")]
        public int ChampionId
        {
            get;
            set;
        }

        [DataMember(Name = "createDate")]
        public long CreateDate
        {
            get;
            set;
        }

        [DataMember(Name = "fellowPlayers")]
        public List<PlayerDto> FellowPlayers
        {
            get;
            set;
        }

        [DataMember(Name = "gameId")]
        public long GameId
        {
            get;
            set;
        }

        [DataMember(Name = "gameMode")]
        public string GameMode
        {
            get;
            set;
        }

        [DataMember(Name = "gameType")]
        public string GameType
        {
            get;
            set;
        }

        [DataMember(Name = "invalid")]
        public bool Invalid
        {
            get;
            set;
        }

        [DataMember(Name = "ipEarned")]
        public int IpEarned
        {
            get;
            set;
        }

        [DataMember(Name = "level")]
        public int Level
        {
            get;
            set;
        }

        [DataMember(Name = "mapId")]
        public int MapId
        {
            get;
            set;
        }

        [DataMember(Name = "spell1")]
        public int Spell1
        {
            get;
            set;
        }

        [DataMember(Name = "spell2")]
        public int Spell2
        {
            get;
            set;
        }

        [DataMember(Name = "stats")]
        public RawStatsDto Stats
        {
            get;
            set;
        }

        [DataMember(Name = "subType")]
        public string SubType
        {
            get;
            set;
        }

        [DataMember(Name = "teamId")]
        public int TeamId
        {
            get;
            set;
        }
    }
}