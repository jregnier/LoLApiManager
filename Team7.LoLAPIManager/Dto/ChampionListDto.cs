namespace Team7.LoLAPIManager.Dto
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