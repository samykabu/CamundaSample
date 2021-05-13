


using Insurance.CRS.Entities.ProviderRequest.Search;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class ProviderCancelReservation
    {
        /// <summary>
        /// Gets or Sets BookingReferenceNo
        /// </summary>
        [JsonProperty(PropertyName = "bookingReferenceNo")]
        public string BookingReferenceNo { get; set; }

        /// <summary>
        /// Gets or Sets RefundAmount
        /// </summary>
        [JsonProperty(PropertyName = "refundAmount")]
        public decimal RefundAmount { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceCode
        /// </summary>
        [JsonProperty(PropertyName = "referenceCode")]
        public string ReferenceCode { get; set; }

        /// <summary>
        /// Gets or Sets CancellationStatus
        /// </summary>
        [JsonProperty(PropertyName = "cancellationStatus")]
        public string CancellationStatus { get; set; }

        /// <summary>
        /// Gets or Sets TpExtensions
        /// </summary>
        [JsonProperty(PropertyName = "tpExtensions")]
        public List<KeyValue> TpExtensions { get; set; }

    }
}
