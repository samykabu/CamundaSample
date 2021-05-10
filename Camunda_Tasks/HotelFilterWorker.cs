using CamundaClient.Dto;
using CamundaClient.Worker;

using System;
using System.Collections.Generic;

namespace Camunda_Tasks
{
    [ExternalTaskTopic("hotelfilter")]
    [ExternalTaskVariableRequirements("addedValue", "jsonresult")]
    class HotelFilterWorker : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {                        
            string jsonAPIResponse = Convert.ToString(externalTask.Variables["jsonresult"].Value);
            decimal addedValue = Convert.ToDecimal(externalTask.Variables["addedValue"].Value);
            object oldValue;

            if (resultVariables.TryGetValue("jsonresult", out oldValue))
            {
                //Modify the Result to the new modified one

            }
            var result = resultVariables;
            resultVariables.Add("jsonresult", "Search Result Modified");
        }

    }
}
