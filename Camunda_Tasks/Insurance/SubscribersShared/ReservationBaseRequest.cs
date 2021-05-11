


using Insurance.CRS.Entities.ProviderRequest.Search;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class ReservationBaseRequest
    {
        /// <summary>
        /// Gets or Sets Companies
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public ReservationCompanyPolicy company { get; set; }

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

        /// <summary>
        /// Gets or Sets DisplayRateInfo
        /// </summary>
        [JsonProperty(PropertyName = "displayRateInfo")]
        public List<DispalyRateInfo> DisplayRateInfo { get; set; }

        ///// <summary>
        ///// Reservation Traveler Information
        ///// </summary>
        //[JsonProperty(PropertyName = "travellerDetails")]
        //public List<TravellerDetails> travellerDetails { get; set; }

        public void AddConfigKey(string key, string value)
        {
            if (Config == null)
                Config = new List<KeyValue>();
            Config.Add(new KeyValue() { Key = key, Value = value });
        }
        public void AddtpExtensions(string key, string value)
        {
            if (TpExtensions == null)
                TpExtensions = new List<KeyValue>();
            TpExtensions.Add(new KeyValue() { Key = key, Value = value });
        }
    }
}
