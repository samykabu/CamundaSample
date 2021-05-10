using CamundaClient.Dto;
using CamundaClient.Worker;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

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

            dynamic jsonrresult = JsonConvert.DeserializeObject<dynamic>(jsonAPIResponse);
            jsonrresult.country = ((string)jsonrresult.country) + " - " + addedValue;
            var result=JsonConvert.SerializeObject(jsonrresult, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            resultVariables.Add("jsonresult", result);// "Search Result Modified");
        }

    }
}
