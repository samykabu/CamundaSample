

using Insurance.CRS.Entities.ProviderRequest.Search;
using Insurance.CRS.Entities.SubscribersShared;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscriberResponse
{
    public class SubscriberServiceSearchResponse
    {
        /// <summary>
        /// Gets or Sets Companies
        /// </summary>
        [JsonProperty(PropertyName = "companies")]
        public List<SearchCompanyPolicy> Companies { get; set; } = new List<SearchCompanyPolicy>();

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public List<KeyValue> Config { get; set; }

        /// <summary>
        /// Gets or Sets TpExtensions
        /// </summary>
        [JsonProperty(PropertyName = "tpExtensions")]
        public List<KeyValue> TpExtensions { get; set; }

    }

}
