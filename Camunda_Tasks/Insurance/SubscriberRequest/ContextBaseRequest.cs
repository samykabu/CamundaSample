namespace Insurance.CRS.Entities.SubscriberRequest
{
    public class ContextBaseRequest
    {        
        /// <summary>
        /// Each API requires context parameter in the request, in which  GDS subscriber has to provide parameters and credentials of its subscriptions with the Ground Service inventory provider.
        /// </summary>
        /// <value>        
        /// </value>
        public Context Context { get; set; }
    }

}
