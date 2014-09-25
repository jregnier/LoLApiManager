namespace Team7.LoLAPIManager.Core.Exceptions
{
    using System.Runtime.Serialization;

    [DataContract]
    public class RateLimitExceeded : BaseLoLException
    {
        public RateLimitExceeded(string message)
            : base(message)
        {
        }
    }
}