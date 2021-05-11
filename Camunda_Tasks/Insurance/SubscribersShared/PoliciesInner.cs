

using Insurance.CRS.Entities.ProviderRequest.Search;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class PoliciesInner
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DateCriteria
        /// </summary>
        [JsonProperty(PropertyName = "dateCriteria")]
        public DateCriteria DateCriteria { get; set; }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [JsonProperty(PropertyName = "criteria")]
        public List<KeyValue> Criteria { get; set; }

        /// <summary>
        /// Gets or Sets IsNoShow
        /// </summary>
        [JsonProperty(PropertyName = "isNoShow")]
        public bool? IsNoShow { get; set; }
    }
}
