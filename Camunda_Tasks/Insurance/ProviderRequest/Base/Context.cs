using System.Collections.Generic;

namespace Insurance.CRS.Entities.ProviderRequest
{
    public class Context
    {
        public string CultureCode { get; set; }
        public string TrackToken { get; set; }
        public List<ProviderInfo> parameters { get; set; } = new List<ProviderInfo>();
    }

}
