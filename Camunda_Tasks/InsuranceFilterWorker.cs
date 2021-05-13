using CamundaClient.Dto;
using CamundaClient.Worker;

using Insurance.CRS.Entities.SubscriberResponse;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using System;
using System.Collections.Generic;

namespace Camunda_Tasks
{
    [ExternalTaskTopic("hotelfilter")]
    [ExternalTaskVariableRequirements("addedValue", "jsonresult")]
    class InsuranceFilterWorker : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            string jsonAPIResponse = Convert.ToString(externalTask.Variables["jsonresult"].Value);
            decimal addedValue = Convert.ToDecimal(externalTask.Variables["addedValue"].Value);
            object oldValue;

            SubscriberBaseResponse<SubscriberServiceSearchResponse> jsonrresult = JsonConvert.DeserializeObject<SubscriberBaseResponse<SubscriberServiceSearchResponse>>(jsonAPIResponse);
            jsonrresult.Status.Code = (int)addedValue;
            foreach (var item in jsonrresult.Response.Companies)
            {
                foreach (var policy in item.InsurancePolicies)
                {
                    policy.DisplayRateInfo.Add(new Insurance.CRS.Entities.SubscribersShared.DispalyRateInfo { 
                        amount = addedValue,
                        purpose = "6", description = "Added By Filter", currencyCode = "SAR" });
                }
            }
            var result = JsonConvert.SerializeObject(jsonrresult, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            Console.WriteLine("******** Insurance Filter ******************************************************************************");
            Console.WriteLine(result);
            Console.WriteLine("****************************************************************************************************");
            resultVariables.Add("jsonresult", result);// "Search Result Modified");
        }

    }
}
