using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace Insurance.CRS.Entities
{
    public class Company
    {
        /// <summary>
        /// Gets or Sets CompanyCode
        /// </summary>
        [JsonProperty(PropertyName = "companyCode")]
        public decimal? CompanyCode { get; set; }

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
        /// Gets or Sets CompanyDescAr
        /// </summary>
        [JsonProperty(PropertyName = "companyDescAr")]
        public string CompanyDescAr { get; set; }

        /// <summary>
        /// Gets or Sets CompanyDescLa
        /// </summary>
        [JsonProperty(PropertyName = "companyDescLa")]
        public string CompanyDescLa { get; set; }

        /// <summary>
        /// Gets or Sets CompanyPhoneCountryCode
        /// </summary>
        [JsonProperty(PropertyName = "companyPhoneCountryCode")]
        public string CompanyPhoneCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyPhone
        /// </summary>
        [JsonProperty(PropertyName = "companyPhone")]
        public string CompanyPhone { get; set; }

        /// <summary>
        /// Gets or Sets CompanyFax
        /// </summary>
        [JsonProperty(PropertyName = "companyFax")]
        public decimal? CompanyFax { get; set; }

        /// <summary>
        /// Gets or Sets CompanyEmail
        /// </summary>
        [JsonProperty(PropertyName = "companyEmail")]
        public string CompanyEmail { get; set; }

        /// <summary>
        /// Gets or Sets CompanyWebPage
        /// </summary>
        [JsonProperty(PropertyName = "companyWebPage")]
        public string CompanyWebPage { get; set; }

        /// <summary>
        /// Gets or Sets CompanyPartyCode
        /// </summary>
        [JsonProperty(PropertyName = "companyPartyCode")]
        public decimal? CompanyPartyCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyLctCode
        /// </summary>
        [JsonProperty(PropertyName = "companyLctCode")]
        public decimal? CompanyLctCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddress1
        /// </summary>
        [JsonProperty(PropertyName = "companyAddress1")]
        public string CompanyAddress1 { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddress2
        /// </summary>
        [JsonProperty(PropertyName = "companyAddress2")]
        public string CompanyAddress2 { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddressCityCode
        /// </summary>
        [JsonProperty(PropertyName = "companyAddressCityCode")]
        public decimal? CompanyAddressCityCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddressCountryCode
        /// </summary>
        [JsonProperty(PropertyName = "companyAddressCountryCode")]
        public decimal? CompanyAddressCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddressPOBox
        /// </summary>
        [JsonProperty(PropertyName = "companyAddressPOBox")]
        public decimal? CompanyAddressPOBox { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddressZip
        /// </summary>
        [JsonProperty(PropertyName = "companyAddressZip")]
        public decimal? CompanyAddressZip { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddressLatitude
        /// </summary>
        [JsonProperty(PropertyName = "companyAddressLatitude")]
        public string CompanyAddressLatitude { get; set; }

        /// <summary>
        /// Gets or Sets CompanyAddressLongitude
        /// </summary>
        [JsonProperty(PropertyName = "companyAddressLongitude")]
        public string CompanyAddressLongitude { get; set; }

        /// <summary>
        /// Gets or Sets CompanyRegNo
        /// </summary>
        [JsonProperty(PropertyName = "companyRegNo")]
        public decimal? CompanyRegNo { get; set; }

        /// <summary>
        /// Gets or Sets CompanyRegDate
        /// </summary>
        [JsonProperty(PropertyName = "companyRegDate")]
        public DateTime? CompanyRegDate { get; set; }

        /// <summary>
        /// Gets or Sets CompanyRegExpireDate
        /// </summary>
        [JsonProperty(PropertyName = "companyRegExpireDate")]
        public DateTime? CompanyRegExpireDate { get; set; }

        /// <summary>
        /// Gets or Sets CompanySamaRegNo
        /// </summary>
        [JsonProperty(PropertyName = "companySamaRegNo")]
        public string CompanySamaRegNo { get; set; }

        /// <summary>
        /// Gets or Sets CompanySamaRegDate
        /// </summary>
        [JsonProperty(PropertyName = "companySamaRegDate")]
        public DateTime? CompanySamaRegDate { get; set; }

        /// <summary>
        /// Gets or Sets CompanySamaRegExpireDate
        /// </summary>
        [JsonProperty(PropertyName = "companySamaRegExpireDate")]
        public DateTime? CompanySamaRegExpireDate { get; set; }

        /// <summary>
        /// Gets or Sets CompanyImages
        /// </summary>
        [JsonProperty(PropertyName = "companyImages")]
        public List<CompanyImages> CompanyImages { get; set; }

        /// <summary>
        /// Gets or Sets CompanyLink
        /// </summary>
        [JsonProperty(PropertyName = "companyLink")]
        public Link CompanyLink { get; set; }



    }
}
