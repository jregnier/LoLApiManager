
namespace Team7.LoLAPIManager.Core.Exceptions
{
    using System.Runtime.Serialization;

    [DataContract]
    public class GameDataNotFound : BaseLoLException
    {
        public GameDataNotFound(string message)
            : base(message)
        {

        }
    }
}
