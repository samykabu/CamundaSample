namespace Insurance.CRS.Entities.SubscriberResponse
{
    public class SubscriberBaseResponse<T> : BaseResponse where T : new()
    {/// <summary>
     /// API Response Body.
     /// </summary>
        public T Response { get; set; } = new T();
    }

}
