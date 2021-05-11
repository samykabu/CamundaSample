namespace Insurance.CRS.Entities.ProviderRequest
{
    public class ProviderBaseRequest<T>
    {
        public Context Context { get; set; } = new Context();
        public T Request { get; set; }
        public string RequestToken { get; set; }
    }

}
