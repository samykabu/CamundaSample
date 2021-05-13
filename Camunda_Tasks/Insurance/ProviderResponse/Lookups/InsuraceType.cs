using Newtonsoft.Json;

namespace Insurance.CRS.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class InsuraceType
    {
        /// <summary>
        /// Gets or Sets TypeCode
        /// </summary>
        [JsonProperty(PropertyName = "typeCode")]
        public decimal? TypeCode { get; set; }

        /// <summary>
        /// Gets or Sets TypeNameAr
        /// </summary>
        [JsonProperty(PropertyName = "typeNameAr")]
        public string TypeNameAr { get; set; }

        /// <summary>
        /// Gets or Sets TypeNameLa
        /// </summary>
        [JsonProperty(PropertyName = "typeNameLa")]
        public string TypeNameLa { get; set; }

        /// <summary>
        /// Gets or Sets TypeLink
        /// </summary>
        [JsonProperty(PropertyName = "typeLink")]
        public Link TypeLink { get; set; }
    }
}
