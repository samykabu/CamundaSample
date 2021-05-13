namespace Insurance.CRS.Entities.SubscriberRequest
{
    public class LookupsRequest<T> : BaseRequest
    {
        public T Request { get; set; }
    }
}
