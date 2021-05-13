

using Insurance.CRS.Entities.ProviderRequest.Search;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Insurance.CRS.Entities.SubscriberRequest
{
    public class SubscriberConfirmCancelReservationRequest_V2
    {
        /// <summary>
        /// booking reference no.
        /// </summary>
        /// <value>
        /// The booking reference no.
        /// </value>
        [Required]
        public string BookingReferenceNo { get; set; }
        /// <summary>
        /// refund amount.
        /// </summary>
        /// <value>
        /// The refund amount.
        /// </value>
        [Required]
        public decimal RefundAmount { get; set; } // the total refund amount        
        /// <summary>
        /// cancellation reason.
        /// </summary>
        /// <value>
        /// The cancellation reason.
        /// </value>
        [Required]
        public string CancellationReason { get; set; }
        /// <summary>
        /// total supplier refund amount
        /// </summary>
        public decimal SupplierRefundAmount { get; set; }
        /// <summary>
        /// total OTA Refund amount
        /// </summary>
        public decimal OtaRefundAmount { get; set; }
        /// <summary>
        /// ePayment Reference Code
        /// </summary>
        [Required]
        public string ReferenceCode { get; set; }
        /// <summary>
        /// tp extensions.
        /// </summary>
        /// <value>
        /// The tp extensions.
        /// </value>
        public List<KeyValue> TpExtensions { get; set; }

        /// <summary>
        /// Service configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public List<KeyValue> Config { get; set; }
        /// <summary>
        ///  the total payment registered at the time of booking.
        /// </summary>
        public decimal BookingPaymentAmount { get; set; }
        [JsonIgnore]
        public string SupplierBookingReferenceNo { get; set; }
    }


}
