using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class CancellationPolicyInner
    {
        /// <summary>
        /// Gets or Sets IsRefundable
        /// </summary>
        
        [JsonProperty(PropertyName = "isRefundable")]
        public bool? IsRefundable { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public List<Object> Rules { get; set; }
    }
}
