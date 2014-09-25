namespace Team7.LoLAPIManager
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Xml.Serialization;

    public static class WebUtility
    {
        public static T DeSerializeJson<T>(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException("content");
            }

            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(stream);
            }
        }

        public static T DeSerializeXml<T>(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException("content");
            }

            using (TextReader stream = new StringReader(content))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}