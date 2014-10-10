
namespace Team7.LoLApiManager.Core.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class LoLApiException<T> : Exception
        where T : BaseLoLException
    {
        public LoLApiException(string message)
            : base(message)
        {
        }
    }
}