using System.Collections.Generic;

namespace Insurance.CRS.Entities.ProviderRequest
{
    public class ProviderInfo : Dictionary<string, object>
    {
        public string trackToken
        {
            get
            {
                try
                {
                    return !this.ContainsKey("trackToken") ? null : this["trackToken"].ToString();
                }
                catch
                {
                    return null;
                }
            }
        }
    }

}
