
using Insurance.CRS.Entities.SubscribersShared;

using Newtonsoft.Json;

namespace Insurance.CRS.Entities.SubscriberResponse
{
    public class SubscriberServiceCheckAvailabilityResponse : CheckAvailabilityBaseResponse
    {
        [JsonProperty(PropertyName = "provider")]
        public string provider { get; set; }
        [JsonProperty(PropertyName = "vendor")]
        public string vendor { get; set; }

        /// <summary>       
    }


}
