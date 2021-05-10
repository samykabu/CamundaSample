using CamundaClient.Dto;
using CamundaClient.Worker;

using RestSharp;

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

            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("nl/3825", Method.GET);
            IRestResponse response = client.Execute(request);

            string Jsonresult = response.Content;
            resultVariables.Add("jsonresult", Jsonresult);
        }

    }
}
