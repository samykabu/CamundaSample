

using Insurance.CRS.Entities.ProviderRequest.Search;
using Insurance.CRS.Entities.SubscribersShared;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscriberRequest
{
    public class SubscriberServiceReservationRequest : ReservationBaseRequest
    {
        [JsonProperty(PropertyName = "provider")]
        public string provider { get; set; }
        [JsonProperty(PropertyName = "vendor")]
        public string vendor { get; set; }

        /// <summary>       
        public List<KeyValue> secureTpExtensions { get; set; }
    }
}
