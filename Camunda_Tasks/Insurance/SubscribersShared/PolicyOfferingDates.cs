using Newtonsoft.Json;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class PolicyOfferingDates
    {
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        
        [JsonProperty(PropertyName = "startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public string EndDate { get; set; }

        

    }
}
