namespace Team7.LoLAPIManager.Core.Exceptions
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ServiceUnavailable : BaseLoLException
    {
        public ServiceUnavailable(string message)
            : base(message)
        {
        }
    }
}