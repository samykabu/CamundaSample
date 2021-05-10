using CamundaClient.Dto;
using CamundaClient.Worker;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda_Tasks
{
    [ExternalTaskTopic("hotelsearch")]
    [ExternalTaskVariableRequirements("checkindate", "checkoutdate")]
    class HotelSearchWorker : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            DateTime checkindate = Convert.ToDateTime(externalTask.Variables["checkindate"].Value);
            DateTime checkoutdate = Convert.ToDateTime(externalTask.Variables["checkoutdate"].Value);
            string Jsonresult = "Search Result Un Modified";
            resultVariables.Add("jsonresult", Jsonresult);
        }

    }
}
