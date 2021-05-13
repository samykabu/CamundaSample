using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Insurance.CRS.Entities
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CompanyImages
    {
        /// <summary>
        /// Gets or Sets SequenceNo
        /// </summary>
        [JsonProperty(PropertyName = "sequenceNo")]
        public decimal? SequenceNo { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
