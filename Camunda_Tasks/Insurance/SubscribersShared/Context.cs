using System.Collections.Generic;

namespace Insurance.CRS.Entities
{

    public class Context
    {
        /// <summary>
        /// ISO format culture code like en-US, ar-AE to receive culture specific inventory
        /// </summary>
        /// <example>
        /// en-US
        /// </example>
        /// <example>en-US</example>
        public string CultureCode { get; set; }

        /// <summary>
        /// Track token is to be passed in every subsequent service's request, if the previous service returns a Track token
        /// </summary>
        /// <value>
        /// </value>
        /// <example>FC93CFE7-31E9-457E-8E8E-C212DCCC0FE2</example>
        public string TrackToken { get; set; }

        /// <summary>
        /// Provider information
        /// </summary>
        /// <value>
        /// </value>
        /// <example>[]</example>
        public List<ProviderInfo> ProviderInfo { get; set; }

        public ProviderRequest.Context ToProviderContext(params KeyValuePair<string, string>[] values)
        {
            var result = new ProviderRequest.Context()
            {
                CultureCode = this.CultureCode
            };
            result.parameters.Add(new ProviderRequest.ProviderInfo() { { "trackToken", TrackToken } });
            if (values != null && values.Length > 0)
            {
                foreach (var contextItem in values)
                {
                    result.parameters.Add(new ProviderRequest.ProviderInfo() { { contextItem.Key, contextItem.Value } });
                }
            }
            return result;
        }
    }
}
