using System;

namespace Insurance.CRS.Entities.SubscriberResponse
{
    public class ResponseStatus
    {
        DateTime startTime = DateTime.Now;

        public int Code { get; set; } = 0;

        public string Message { get; set; } = "Success";

        public double ExecutionTime()
        {
            return (DateTime.Now - startTime).TotalMilliseconds;
        }

        public void Set(ResponseStatus status)
        {
            if (status != null)
            {
                this.Code = status.Code;
                this.Message = status.Message;
            }
        }
    }
}
