using System.Collections.Generic;

namespace Insurance.CRS.Entities
{
    public class ProviderInfo : Dictionary<string, object>
    {
        public string Provider
        {
            get
            {
                try
                {
                    return !this.ContainsKey("provider") ? null : this["provider"].ToString();
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
