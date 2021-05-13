namespace Insurance.CRS.Entities.SubscriberRequest
{
    /// <summary>
    /// Check Reservation Status Inner Request
    /// </summary>
    public class CheckReservationStatusInnerRequest
    {
        /// <summary>
        /// Reservation Track Token
        /// </summary>
        public string TrackToken { get; set; }


        /// <summary>
        /// Reservation Check Availability Id
        /// </summary>
        public string CheckAvailLogId { get; set; }
    }
}
