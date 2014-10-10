// <copyright file="ServiceBase.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Services
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Team7.LoLApiManager.Core;
    using Team7.LoLApiManager.Core.Exceptions;

    /// <summary>
    /// Base class for all of Riots LoL services.
    /// </summary>
    public abstract class ServiceBase
    {
        #region Constants

        private const string baseURL = "https://{0}.api.pvp.net/";

        private const string relativeURL = "api/lol/{0}/{1}/";

        #endregion Constants

        #region Properties

        public string ApiKey { get; private set; }

        public Uri BaseUri { get; private set; }

        public ApiEndPoints EndPoint { get; private set; }

        public ApiRegions Region { get; private set; }

        public ApiVersions Version { get; private set; }

        #endregion Properties

        #region Constructors

        /// <summary> Construct a new instance of the <see cref="ServiceBase"/> Class. </summary>
        /// <param name="region">The region to use in the web service calls.</param> <param
        /// name="ver"><The version of the particular service.</param> <param name="endPoint">The
        /// end point for the given service.</param>
        public ServiceBase(ApiRegions region, ApiVersions ver, ApiEndPoints endPoint, string key)
        {
            Region = region;
            Version = ver;
            EndPoint = endPoint;
            ApiKey = key;

            BaseUri = new Uri(string.Format(baseURL, Regions.GetRegions[region]));

            CreateMapping();

            RateLimitManager.Instance.Add(ApiKey);
        }

        #endregion Constructors

        /// <summary>
        /// Build the relative URL of the web service call, Override this method to change the
        /// standard 'api/lol/{region}/{version}/' relative URL.
        /// </summary>
        /// <returns>The relative URL</returns>
        protected virtual Uri BuildRelativeUri()
        {
            string relative = string.Format(relativeURL, Regions.GetRegions[Region], Versions.GetVersions[Version]);

            relative += EndPoints.GetEndPoints[EndPoint];

            var relativeUri = new Uri(relative, UriKind.Relative);

            return relativeUri;
        }

        protected abstract void CreateMapping();

        /// <summary>
        /// Do a Web Get for the given request Uri .
        /// </summary>
        /// <typeparam name="T">The Type of object to serialize the object into.</typeparam>
        /// <param name="requestUri">The request URL to append to the end of the base Uri.</param>
        /// <returns>The given <see cref="T"/> object.</returns>
        protected async Task<T> WebGetAsync<T>(Uri requestUri) where T : class
        {
            RateLimitManager.Instance.HandleRate(ApiKey);

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
                else
                {
                    string message = await response.Content.ReadAsStringAsync();

                    switch ((int)response.StatusCode)
                    {
                        case (int)LoLApiErrors.BadRequest:
                            throw new LoLApiException<BadRequest>(message);
                        case (int)LoLApiErrors.Unauthorized:
                            throw new LoLApiException<Unauthorized>(message);
                        case (int)LoLApiErrors.DataNotFound:
                            throw new LoLApiException<DataNotFound>(message);
                        case (int)LoLApiErrors.RateLimitExceeded:
                            throw new LoLApiException<RateLimitExceeded>(message);
                        case (int)LoLApiErrors.InternalServerError:
                            throw new LoLApiException<InternalServerError>(message);
                        case (int)LoLApiErrors.ServiceUnavailable:
                            throw new LoLApiException<ServiceUnavailable>(message);
                        default:
                            response.EnsureSuccessStatusCode();
                            break;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Build the Uri to make the web call
        /// </summary>
        /// <param name="requestUri">The request Uri to use in the Total Uri</param>
        /// <returns>The built Uri</returns>
        private Uri BuildUri(Uri requestUri = null)
        {
            string uriString = BaseUri.OriginalString;

            uriString += BuildRelativeUri().OriginalString;

            if (requestUri != null)
            {
                uriString += requestUri;
            }

            UriBuilder uriBuilder = new UriBuilder(uriString);
            uriBuilder.Port = -1;
            if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
                uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + string.Format("api_key={0}", ApiKey);
            else
                uriBuilder.Query = string.Format("api_key={0}", ApiKey);

            return uriBuilder.Uri;
        }
    }
}