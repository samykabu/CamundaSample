using CamundaClient.Dto;
using CamundaClient.Worker;

using System;
using System.Collections.Generic;

namespace Camunda_Tasks
{
    [ExternalTaskTopic("searchresponse")]
    class searchresponse : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            string jsonAPIResponse = Convert.ToString(externalTask.Variables["jsonresult"].Value);            

            resultVariables.Add("jsonresult", "Result consolidated");            
        }

    }
}
