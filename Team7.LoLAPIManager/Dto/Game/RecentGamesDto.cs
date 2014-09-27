namespace Team7.LoLAPIManager.Dto.Game
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class RecentGamesDto
    {
        [DataMember(Name = "games")]
        public List<GameDto> Games
        {
            get;
            set;
        }

        [DataMember(Name = "summonerId")]
        public long SummonerId
        {
            get;
            set;
        }
    }
}