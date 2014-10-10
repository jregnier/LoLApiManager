// <copyright file="ChampionListDto.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Dto.Champion
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ChampionListDto
    {
        [DataMember(Name = "champions")]
        public List<ChampionDto> Champions
        {
            get;
            set;
        }
    }
}