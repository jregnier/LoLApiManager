
namespace Team7.LoLAPIManager.Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RateLimit
    {
        public const int TenSecondRateLimit = 10;
        public const int RequestsPerTenSeconds = 10;
        public const int TenMinuteRateLimitInSeconds = 600;
        public const int RequestsPerTenMinutes = 500;

        public string Key { get; set; }

        public List<DateTime> WebServiceCalls { get; set; }

        public RateLimit()
        {
            WebServiceCalls = new List<DateTime>();
        }

        public int GetDelay(int rateInSeconds, int numRequests)
        {
            if (rateInSeconds == 0)
            {
                throw new ArgumentException("rateInSeconds");
            }

            if (numRequests == 0)
            {
                throw new ArgumentException("numRequests");
            }

            // Delete an extra call traces, always only keep 550 in the list.
            // Convert the List into a HashSet in order to query much faster
            WebServiceCalls.RemoveRange(0, WebServiceCalls.Count - (RequestsPerTenMinutes + 50));
            HashSet<DateTime> hash = new HashSet<DateTime>(WebServiceCalls);

            // Get the request that are within the rate passed in
            var requestsInRate = (from call in hash
                                 where call >= DateTime.Now.AddSeconds(-rateInSeconds)
                                 orderby call ascending
                                 select call).ToList();

            int delay = 0;

            // If the limit has been reached then calculate the needed delay
            if (requestsInRate.Count >= numRequests)
            {
                TimeSpan diff = requestsInRate[0] - DateTime.Now.AddSeconds(-rateInSeconds);
                delay = (int)Math.Abs(diff.Milliseconds);
            }

            return delay;
        }

    }
}
