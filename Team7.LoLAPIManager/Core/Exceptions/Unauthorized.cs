namespace Team7.LoLAPIManager.Core.Exceptions
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Unauthorized : BaseLoLException
    {
        public Unauthorized(string message)
            : base(message)
        {
        }
    }
}