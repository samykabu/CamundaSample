



using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class ReservationCompanyPolicy
    {
        /// <summary>
        /// Gets or Sets CompanyCode
        /// </summary>
        [JsonProperty(PropertyName = "companyCode")]
        public long CompanyCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyNameAr
        /// </summary>
        [JsonProperty(PropertyName = "companyNameAr")]
        public string CompanyNameAr { get; set; }

        /// <summary>
        /// Gets or Sets CompanyNameLa
        /// </summary>
        [JsonProperty(PropertyName = "companyNameLa")]
        public string CompanyNameLa { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        [JsonConverter(typeof(jsonDateFormatConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets InsurancePolicy
        /// </summary>
        [JsonProperty(PropertyName = "insurancePolicy")]
        public InsurancePolicy InsurancePolicy { get; set; }

        /// <summary>
        /// Gets or Sets CancellationPolicy
        /// </summary>
        [JsonProperty(PropertyName = "cancellationPolicy")]
        public List<CancellationPolicyInner> CancellationPolicy { get; set; }

        /// <summary>
        /// Gets or Sets Policies
        /// </summary>
        [JsonProperty(PropertyName = "policies")]
        public List<PoliciesInner> Policies { get; set; }

        /// <summary>
        /// Gets or Sets TermsAndConditions
        /// </summary>
        [JsonProperty(PropertyName = "termsAndConditions")]
        public string TermsAndConditions { get; set; }

        /// <summary>
        /// Gets or Sets DisplayRateInfo
        /// </summary>
        [JsonProperty(PropertyName = "displayRateInfo")]
        public List<DispalyRateInfo> DisplayRateInfo { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [JsonProperty(PropertyName = "contactDetails")]
        [JsonRequired]
        public object ContactDetails { get; set; }

    }
    public class DispalyRateInfo
    {
        public decimal amount { get; set; }
        public string description { get; set; }
        public string currencyCode { get; set; }
        public string purpose { get; set; }
    }
}
