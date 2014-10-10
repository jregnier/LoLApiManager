namespace Team7.LoLApiManager.Core.Exceptions
{
    using System.Runtime.Serialization;

    [DataContract]
    public class DataNotFound : BaseLoLException
    {
        public DataNotFound(string message)
            : base(message)
        {
        }
    }
}