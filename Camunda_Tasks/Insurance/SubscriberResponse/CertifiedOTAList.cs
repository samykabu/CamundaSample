using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscriberResponse
{
    /// <summary>
    /// Certified OTA Response
    /// </summary>
    public class CertifiedOTAList : SubscriberBaseResponse<List<OTADetailsResponse>>
    {
        /// <summary>
        ///  Hotel Policy Response
        /// </summary>
        public CertifiedOTAList()
        {
            Response = new List<OTADetailsResponse>();
        }
    }

}
