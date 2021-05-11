
using System;
using System.Collections.Generic;

namespace Insurance.CRS.Entities.SubscriberResponse
{
    public class BaseResponse
    {
        /// <summary>
        /// Response Status
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public ResponseStatus Status { get; set; } = new ResponseStatus();

        /// <summary>
        /// Response Context
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        public ResponseContext Context { get; set; } = new ResponseContext();

        /// <summary>
        /// Response Info
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public ResponseInfo Info { get; set; } = new ResponseInfo();

        /// <summary>
        /// Response Flags
        /// </summary>
        /// <value>
        /// The flags.
        /// </value>
        public Dictionary<string, bool> Flags { get; set; } = new Dictionary<string, bool>();

        /// <summary>
        /// Errors
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public List<BusinessError> Errors { get; set; } = null;
        public void AddError(BusinessError err)
        {
            if (Errors == null)
                Errors = new List<BusinessError>();
            Errors.Add(err);
            this.Status.Code = 1;
            this.Status.Message = "Error";
        }

        public void LogException(Exception exp, string provider = "", bool isDebugMode = false)
        {
            if (this.Errors == null)
            {
                this.Errors = new List<BusinessError>();
            }

            string errMsg = "Application Internal Exception!";
            string extraDetails = string.Empty;


            if (isDebugMode)
            {
                errMsg = exp.Message;
                extraDetails = exp.StackTrace;
            }

            this.Errors.Add(new BusinessError()
            {
                Provider = provider,
                Code = "EXCEPTION",
                Message = errMsg,
                ExtraDetails = extraDetails,
                Level = 1
            }
            );

            this.Status.Code = 1;
            this.Status.Message = "UnknownError";
        }
    }
}
