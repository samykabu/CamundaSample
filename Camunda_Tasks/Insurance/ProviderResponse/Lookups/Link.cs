using Newtonsoft.Json;

namespace Insurance.CRS.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Rel
        /// </summary>
        [JsonProperty(PropertyName = "rel")]
        public string Rel { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }



    }
}
