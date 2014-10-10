namespace Team7.LoLApiManager.Core.Exceptions
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;

    [DataContract]
    public class BaseLoLException : Exception
    {
        public BaseLoLException(string message)
            : base(string.Format(CultureInfo.InvariantCulture, "{0}, {1}", Properties.Resources.RiotError, message))
        {
        }
    }
}