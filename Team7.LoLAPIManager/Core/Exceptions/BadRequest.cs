namespace Team7.LoLApiManager.Core.Exceptions
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