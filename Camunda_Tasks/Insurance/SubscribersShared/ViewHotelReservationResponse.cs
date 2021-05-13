
using Newtonsoft.Json;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class ViewHotelReservationResponse
    {
        /// <summary>
        /// View Hotel Reservation Response
        /// </summary>
        public string bookingReferenceNo { get; set; }

        public string BookingDate { get; set; }
        public string BookingStatus { get; set; }
        [JsonProperty(PropertyName = "company")]
        public ReservationCompanyPolicy company { get; set; }
    }
}
