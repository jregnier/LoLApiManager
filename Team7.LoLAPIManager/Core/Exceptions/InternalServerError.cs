namespace Team7.LoLAPIManager.Core.Exceptions
{
    using System.Runtime.Serialization;

    [DataContract]
    public class InternalServerError : BaseLoLException
    {
        public InternalServerError(string message)
            : base(message)
        {
        }
    }
}