using Newtonsoft.Json.Converters;

namespace Insurance.CRS.Entities
{
    public class jsonDateFormatConverter : IsoDateTimeConverter
    {
        public jsonDateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
