
using Newtonsoft.Json;

using System;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class SearchBaseRequest
    {
        /// <summary>
        /// Company Code
        /// </summary>
        /// <example>1005</example>
        [JsonProperty(PropertyName = "companyCode")]
        public long? CompanyCode { get; set; }

        /// <summary>
        /// Start Date
        /// </summary>
        ///<example>2020-10-15</example>
        [JsonProperty(PropertyName = "startDate")]
        [JsonConverter(typeof(jsonDateFormatConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Policy Type Code
        /// </summary>
        /// <example>1000</example>
        [JsonProperty(PropertyName = "policyTypeCode")]
        public long? PolicyTypeCode { get; set; }

        /// <summary>
        /// PolicyCategoryCode
        /// </summary>
        /// <example>"1000"</example>
        [JsonProperty(PropertyName = "policyCategoryCode")]
        public string PolicyCategoryCode { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <example>1</example>
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; set; }
    }

}
