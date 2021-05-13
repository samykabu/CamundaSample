namespace Insurance.CRS.Entities.ProviderRequest.Cancel
{
    public class ProviderConfirmCancelReservationRequest
    {
        public string BookingReferenceNo { get; set; }
        public decimal RefundAmount { get; set; } // the total refund amount
        public string CancellationReason { get; set; }
        public string ReferenceCode { get; set; }
    }
}
