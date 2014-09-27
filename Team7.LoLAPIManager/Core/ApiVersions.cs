namespace Team7.LoLAPIManager.Core
{
    using System.Collections.Generic;

    public enum ApiVersions
    {
        V1_0,
        V1_1,
        V1_2,
        V1_3,
        V1_4,
        V2_1,
        V2_2,
        V2_3,
        V2_4,
        V2_5,
        NONE
    }

    public static class Versions
    {
        public static Dictionary<ApiVersions, string> _versions;

        public static Dictionary<ApiVersions, string> GetVersions
        {
            get
            {
                if (_versions == null)
                {
                    _versions = new Dictionary<ApiVersions, string>()
                    {
                        { ApiVersions.V1_0, "v1" },
                        { ApiVersions.V1_1, "v1.1" },
                        { ApiVersions.V1_2, "v1.2" },
                        { ApiVersions.V1_3, "v1.3" },
                        { ApiVersions.V1_4, "v1.4" },
                        { ApiVersions.V2_1, "v2.1" },
                        { ApiVersions.V2_2, "v2.2" },
                        { ApiVersions.V2_3, "v2.3" },
                        { ApiVersions.V2_4, "v2.4" },
                        { ApiVersions.V2_4, "v2.5" }
                    };
                }

                return _versions;
            }
        }
    }
}