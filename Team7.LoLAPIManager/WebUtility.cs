// <copyright file="WebUtility.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Xml.Serialization;

    /// <summary>
    /// Utility class related to web.
    /// </summary>
    public static class WebUtility
    {
        /// <summary> Deserialize the JSON content string into the given type. </summary> <typeparam
        /// name="T">The type of object to deserialize into.</typeparam> <param name="content">The
        /// string content to deserialize</param> <returns>A <see cref="{DeSerializeJson<T>}"/>
        /// filled with the content.</returns>
        public static T DeSerializeJson<T>(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException("content");
            }

            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
            settings.UseSimpleDictionaryFormat = true;

            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T), settings);
                return (T)serializer.ReadObject(stream);
            }
        }

        /// <summary> Deserialize the XML content string into the given type. </summary> <typeparam
        /// name="T">The type of object to deserialize into.</typeparam> <param name="content">The
        /// string content to deserialize</param> <returns>A <see cref="{DeSerializeJson<T>}"/>
        /// filled with the content.</returns>
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