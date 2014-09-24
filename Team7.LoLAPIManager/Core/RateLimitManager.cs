
namespace Team7.LoLAPIManager.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class RateLimitManager : List<RateLimit>
    {
        #region Singleton

        private static RateLimitManager _instance;

        public static RateLimitManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RateLimitManager();
                }

                return _instance;
            }
        }

        #endregion

        public void Add(string key)
        {
            if (!this.Exists(r => r.Key == key))
            {
                this.Add(new RateLimit() { Key = key });
            }
        }

        /// <summary>
        /// Handle the rate limits for the Riot API
        /// </summary>
        /// <param name="key">The Riot Api Key given for the application</param>
        public async Task HandleRateAsync(string key)
        {
            RateLimit rateLimit = this.Where(r => r.Key == key).FirstOrDefault();

            // Get both delay values for 10 seconds and 10 minutes
            int delay1 = rateLimit.GetDelay(RateLimit.TenMinuteRateLimitInSeconds, RateLimit.RequestsPerTenMinutes);
            int delay2 = rateLimit.GetDelay(RateLimit.TenSecondRateLimit, RateLimit.RequestsPerTenSeconds);

            if (delay1 != 0 || delay2 != 0)
            {
                // Do an async delay based on the biggest delay calculated, then add 500 milliseconds
                await Task.Delay(Math.Max(delay1, delay2) + 500);
            }           

            rateLimit.WebServiceCalls.Add(DateTime.Now);
        }
    }
}
