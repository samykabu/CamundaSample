using System.ComponentModel.DataAnnotations;

namespace Insurance.CRS.Entities.SubscriberRequest
{
    public class SubscriberBaseRequest<T> : BaseRequest
    {
        /// <summary>
        /// 	API specific request object/parameters
        /// </summary>
        /// <value>
        /// </value>
        [Required]
        public T request { get; set; }
    }
}
