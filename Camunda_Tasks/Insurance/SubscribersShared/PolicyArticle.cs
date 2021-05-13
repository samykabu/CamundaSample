using Newtonsoft.Json;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class PolicyArticle
    {
        /// <summary>
        /// Gets or Sets ArticleCode
        /// </summary>
        [JsonProperty(PropertyName = "articleCode")]
        public long? ArticleCode { get; set; }

        /// <summary>
        /// Gets or Sets ArticleDescAr
        /// </summary>
        [JsonProperty(PropertyName = "articleDescAr")]
        public string ArticleDescAr { get; set; }

        /// <summary>
        /// Gets or Sets ArticleDescLa
        /// </summary>
        [JsonProperty(PropertyName = "articleDescLa")]
        public string ArticleDescLa { get; set; }

        /// <summary>
        /// Gets or Sets ArticleOrder
        /// </summary>
        [JsonProperty(PropertyName = "articleOrder")]
        public long? ArticleOrder { get; set; }
    }
}
