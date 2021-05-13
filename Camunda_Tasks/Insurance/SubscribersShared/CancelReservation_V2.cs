


using Insurance.CRS.Entities.ProviderRequest.Search;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class CancelReservation_V2
    {
        /// <summary>
        /// Booking Reference No
        /// </summary>
        [JsonProperty(PropertyName = "bookingReferenceNo")]
        public string BookingReferenceNo { get; set; }

        /// <summary>
        /// Refund Amount
        /// </summary>
        [JsonProperty(PropertyName = "refundAmount")]
        public decimal RefundAmount { get; set; }

        /// <summary>
        /// total supplier refund amount
        /// </summary>
        public decimal SupplierRefundAmount { get; set; }
        /// <summary>
        /// total OTA Refund amount
        /// </summary>
        public decimal OtaRefundAmount { get; set; }


        /// <summary>
        /// the booking payment amount.
        /// </summary>
        /// <value>
        /// The booking payment amount.
        /// </value>
        public decimal BookingPaymentAmount { get; set; }


        /// <summary>
        /// E-Payment Reference Code
        /// </summary>
        [JsonProperty(PropertyName = "referenceCode")]
        public string ReferenceCode { get; set; }

        /// <summary>
        /// Cancellation Status
        /// </summary>
        [JsonProperty(PropertyName = "cancellationStatus")]
        public string CancellationStatus { get; set; }

        /// <summary>
        /// TpExtensions
        /// </summary>
        [JsonProperty(PropertyName = "tpExtensions")]
        public List<KeyValue> TpExtensions { get; set; }

        /// <summary>
        /// TpExtensions
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public List<KeyValue> Config { get; set; }
    }

}
