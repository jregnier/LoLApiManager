
namespace Team7.LoLAPIManager.Services
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Team7.LoLAPIManager.Core;

    public abstract class ServiceBase
    {
        #region Constants

        private const string baseURL = "https://{0}.api.pvp.net/";

        private const string versionedURL = "api/lol/{0}/{1}/";

        #endregion


        #region Properties

        public Uri BaseUri { get; set; }

        public Uri VersionedUri { get; set; }

        public ApiRegions Region { get; set; }

        public ApiVersions Version { get; private set; }

        public ApiEndPoints EndPoint { get; private set; }

        public string ApiKey { get; private set; }

        public bool IsVersioned { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Construct a new instance of the <see cref="Service Base"/> Class.
        /// </summary>
        /// <param name="region">The region to use in the web service calls.</param>
        /// <param name="ver"><The version of the particular service.</param>
        /// <param name="endPoint">The end point for the given service.</param>
        public ServiceBase(ApiRegions region, ApiVersions ver, ApiEndPoints endPoint, string key, bool isVersioned)
        {
            Region = region;
            Version = ver;
            EndPoint = endPoint;
            ApiKey = key;
            IsVersioned = isVersioned;

            BaseUri = new Uri(string.Format(baseURL, Regions.GetRegions[region]));

            if(IsVersioned)
            {
                VersionedUri = new Uri(string.Format(versionedURL, Regions.GetRegions[region], Versions.GetVersions[ver]), UriKind.Relative);
            }

            CreateMapping();

            RateLimitManager.Instance.Add(ApiKey);
        }

        #endregion

        /// <summary>
        /// Do a Web Get for the given request Uri .
        /// </summary>
        /// <typeparam name="T">The Type of object to serialize the object into.</typeparam>
        /// <param name="requestUri">The request uri to append to the end of the base Uri.</param>
        /// <returns>The given <see cref="T"/> object.</returns>
        protected async Task<T> WebGetAsync<T>(Uri requestUri) where T : class
        {
            await RateLimitManager.Instance.HandleRateAsync(ApiKey);

            using (var client = new HttpClient())
            {
                client.BaseAddress = BaseUri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(BuildUri(requestUri));
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = response.Content.ReadAsStringAsync().Result;

                    T obj = WebUtility.DeSerializeJson<T>(jsonString);
                    return obj;
                }
            }

            return null;
        }

        /// <summary>
        /// Build the Uri to make the web call 
        /// </summary>
        /// <param name="requestUri">The request Uri to use in the Total Uri</param>
        /// <returns>The built Uri</returns>
        protected virtual Uri BuildUri(Uri requestUri)
        {
            string uriString = BaseUri.OriginalString;

            if (IsVersioned)
            {
                uriString += VersionedUri.OriginalString;
            }

            uriString += requestUri;

            UriBuilder uriBuilder = new UriBuilder(uriString);
            uriBuilder.Port = -1;
            if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
                uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + string.Format("api_key={0}", ApiKey);
            else
                uriBuilder.Query = string.Format("api_key={0}", ApiKey);

            return uriBuilder.Uri;
        }

        protected abstract void CreateMapping();
    }
}
