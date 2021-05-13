

using Insurance.CRS.Entities.ProviderRequest.Search;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscriberRequest
{
    public class SubscriberConfirmCancelReservationResponse
    {
        public string BookingReferenceNo { get; set; }

        public string BookingStatus { get; set; }

        public List<KeyValue> TpExtensions { get; set; }
        public List<KeyValue> Config { get; set; }
    }
}
