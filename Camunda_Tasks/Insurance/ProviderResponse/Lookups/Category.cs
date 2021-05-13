using Newtonsoft.Json;

namespace Insurance.CRS.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or Sets CategoryCode
        /// </summary>
        [JsonProperty(PropertyName = "categoryCode")]
        public decimal? CategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets CategoryNameAr
        /// </summary>
        [JsonProperty(PropertyName = "categoryNameAr")]
        public string CategoryNameAr { get; set; }

        /// <summary>
        /// Gets or Sets CategoryNameLa
        /// </summary>
        [JsonProperty(PropertyName = "categoryNameLa")]
        public string CategoryNameLa { get; set; }

        /// <summary>
        /// Gets or Sets CategoryLink
        /// </summary>
        [JsonProperty(PropertyName = "categoryLink")]
        public Link CategoryLink { get; set; }

    }
}
