namespace Insurance.CRS.Entities.ProviderRequest
{
    public class ProviderLookupBaseRequest
    {
        public Context Context { get; set; } = new Context();
        public string RequestToken { get; set; }
    }

}
