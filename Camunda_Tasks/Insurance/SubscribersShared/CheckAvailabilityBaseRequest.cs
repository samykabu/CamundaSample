

using Insurance.CRS.Entities.ProviderRequest.Search;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class CheckAvailabilityBaseRequest
    {
        /// <summary>
        /// Gets or Sets Companies
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public CheckAvailabilityCompanyPolicy company { get; set; }

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
