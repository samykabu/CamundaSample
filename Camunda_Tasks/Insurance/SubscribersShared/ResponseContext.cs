namespace Insurance.CRS.Entities
{
    public class ResponseContext
    {
        public string TrackToken { get; set; } = System.Guid.NewGuid().ToString();
    }
}