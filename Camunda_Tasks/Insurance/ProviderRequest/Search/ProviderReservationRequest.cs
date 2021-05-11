
using Insurance.CRS.Entities.SubscribersShared;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.ProviderRequest.Search
{
    public class ProviderReservationRequest : CheckAvailabilityBaseResponse
    {
        public List<KeyValue> secureTpExtensions { get; set; }
    }
    public class KeyValue
    {
        public KeyValue()
        {

        }

        public KeyValue(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
        /// <summary>key</summary>
        /// <example></example>
        public string Key { get; set; }
        /// <summary>Value</summary>
        /// <example></example>
        public string Value { get; set; }
    }
}
