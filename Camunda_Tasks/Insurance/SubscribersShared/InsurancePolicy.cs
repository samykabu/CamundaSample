

using Insurance.CRS.Entities.ProviderRequest.Search;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class InsurancePolicy
    {
        /// <summary>
        /// Gets or Sets PolicyCode
        /// </summary>
        [JsonProperty(PropertyName = "policyCode")]
        public long? PolicyCode { get; set; }

        /// <summary>
        /// Gets or Sets PolicyTypeCode
        /// </summary>
        [JsonProperty(PropertyName = "policyTypeCode")]
        public long? PolicyTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets PolicyTypeAr
        /// </summary>
        [JsonProperty(PropertyName = "policyTypeAr")]
        public string PolicyTypeAr { get; set; }

        /// <summary>
        /// Gets or Sets PolicyTypeLa
        /// </summary>
        [JsonProperty(PropertyName = "policyTypeLa")]
        public string PolicyTypeLa { get; set; }

        /// <summary>
        /// Gets or Sets PolicyCategoryCode
        /// </summary>
        [JsonProperty(PropertyName = "policyCategoryCode")]
        public string PolicyCategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets PolicyCategoryAr
        /// </summary>
        [JsonProperty(PropertyName = "policyCategoryAr")]
        public string PolicyCategoryAr { get; set; }

        /// <summary>
        /// Gets or Sets PolicyCategoryLa
        /// </summary>
        [JsonProperty(PropertyName = "policyCategoryLa")]
        public string PolicyCategoryLa { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets or Sets PolicyOfferingDates
        /// </summary>
        [JsonProperty(PropertyName = "policyOfferingDates")]
        public PolicyOfferingDates PolicyOfferingDates { get; set; }

        /// <summary>
        /// Gets or Sets PolicyDurationInDays
        /// </summary>
        [JsonProperty(PropertyName = "policyDurationInDays")]
        public long? PolicyDurationInDays { get; set; }

        /// <summary>
        /// Gets or Sets DisplayRateInfo
        /// </summary>
        [JsonProperty(PropertyName = "displayRateInfo")]
        public List<DispalyRateInfo> DisplayRateInfo { get; set; }

        /// <summary>
        /// Gets or Sets PolicyArticles
        /// </summary>
        [JsonProperty(PropertyName = "PolicyArticles")]
        public List<PolicyArticle> PolicyArticles { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public List<KeyValue> Config { get; set; }

        /// <summary>
        /// Gets or Sets TpExtensions
        /// </summary>
        [JsonProperty(PropertyName = "tpExtensions")]
        public List<KeyValue> TpExtensions { get; set; }

    }
}
