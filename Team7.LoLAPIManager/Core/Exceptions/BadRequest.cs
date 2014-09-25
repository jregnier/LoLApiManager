namespace Team7.LoLAPIManager.Core.Exceptions
{
    using System.Runtime.Serialization;

    [DataContract]
    public class BadRequest : BaseLoLException
    {
        public BadRequest(string message)
            : base(message)
        {
        }
    }
}