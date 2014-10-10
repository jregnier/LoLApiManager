namespace Team7.LoLApiManager.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RateLimit
    {
        public const int RequestsPerTenMinutes = 500;
        public const int RequestsPerTenSeconds = 10;
        public const int TenMinuteRateLimitInSeconds = 600;
        public const int TenSecondRateLimit = 10;

        public RateLimit()
        {
            WebServiceCalls = new List<DateTime>();
        }

        public string Key { get; set; }

        public List<DateTime> WebServiceCalls { get; set; }

        public int GetDelay(int rateInSeconds, int numRequests)
        {
            int delay = 0;

            if (rateInSeconds == 0)
            {
                throw new ArgumentException("rateInSeconds");
            }

            if (numRequests == 0)
            {
                throw new ArgumentException("numRequests");
            }

            if (WebServiceCalls.Count > 0)
            {
                // Delete an extra call traces, always only keep 550 in the list. Convert the List
                // into a HashSet in order to query much faster
                if (WebServiceCalls.Count > RequestsPerTenMinutes + 50)
                {
                    WebServiceCalls.RemoveRange(0, WebServiceCalls.Count - (RequestsPerTenMinutes + 50));
                }

                HashSet<DateTime> hash = new HashSet<DateTime>(WebServiceCalls);

                // Get the request that are within the rate passed in
                var requestsInRate = (from call in hash
                                      where call >= DateTime.Now.AddSeconds(-rateInSeconds)
                                      orderby call ascending
                                      select call).ToList();

                // If the limit has been reached then calculate the needed delay
                if (requestsInRate.Count >= numRequests)
                {
                    TimeSpan diff = requestsInRate[0] - DateTime.Now.AddSeconds(-rateInSeconds);
                    delay = (int)Math.Abs(diff.Milliseconds);
                }
            }

            return delay;
        }
    }
}