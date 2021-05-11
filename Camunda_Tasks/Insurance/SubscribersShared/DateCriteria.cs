using Newtonsoft.Json;

using System;

namespace Insurance.CRS.Entities.SubscribersShared
{
    public class DateCriteria
    {
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }
    }
}
