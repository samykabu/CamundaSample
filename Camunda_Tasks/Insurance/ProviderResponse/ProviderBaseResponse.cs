using Insurance.CRS.Entities.SubscriberResponse;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Insurance.CRS.Entities.ProviderResponse
{
    public class ProviderBaseResponse<T>
    {
        [Required]
        public ResponseStatus Status { get; set; } = new ResponseStatus();
        [Required]
        public ResponseContext Context { get; set; } = new ResponseContext();
        [Required]
        public ResponseInfo Info { get; set; } = new ResponseInfo();
        public T Response { get; set; }

        public object Flags { get; set; }

        public List<BusinessError> Errors { get; set; }
        public void AddError(BusinessError err)
        {
            if (Errors == null)
                Errors = new List<BusinessError>();
            Errors.Add(err);
        }


    }
}