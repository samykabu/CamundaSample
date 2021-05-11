namespace Insurance.CRS.Entities
{
    public class BusinessError
    {
        public string Provider { get; set; }

        public int Level { get; set; }

        public string Code { get; set; }

        public string Message { get; set; }

        public object ExtraDetails { get; set; }
    }
}