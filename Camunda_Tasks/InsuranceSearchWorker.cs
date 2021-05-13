using CamundaClient.Dto;
using CamundaClient.Worker;

using RestSharp;

using System;
using System.Collections.Generic;

namespace Camunda_Tasks
{
    [ExternalTaskTopic("hotelsearch")]
    [ExternalTaskVariableRequirements("checkindate", "checkoutdate")]
    class InsuranceSearchWorker : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            DateTime checkindate = Convert.ToDateTime(externalTask.Variables["checkindate"].Value);
            DateTime checkoutdate = Convert.ToDateTime(externalTask.Variables["checkoutdate"].Value);

            //RestClient client = new RestClient("https://newqaapi.gds.haj.gov.sa/api/hotel/2.5/searchwithdetails"); //api/insurance/v2.0/search
            RestClient client = new RestClient("https://newqaapi.gds.haj.gov.sa/api/insurance/v2.0/search");
            //var jsonRequest = "{  \"context\": {    \"cultureCode\": \"en\",    \"providerInfo\": [      {        \"provider\": \"HUDXCONNECT\"      }    ]  },  \"request\": {    \"providerLocations\": [      {        \"provider\": \"HUDXCONNECT\",        \"locationCode\":\"SA1\",         \"type\": \"location\",        \"countryCode\": \"SA\",        \"hotelCodes\": [\"18075\"]      }    ],	\"checkInDate\": \"" + checkindate.ToString("yyyy-MM-dd") + "\",    \"checkOutDate\": \"" + checkoutdate.ToString("yyyy-MM-dd") + "\",    \"rooms\": [      {        \"sequence\": 0,        \"paxInfo\": [          {            \"type\": \"ADT\",            \"quantity\": 1,            \"age\": 0          }        ]      }    ],    \"status\": \"Available\",    \"amountType\": \"Total\"  }}";
            var jsonRequest = "{ \"context\": {\"cultureCode\": \"en-US\",\"providerinfo\": [],\"tracktoken\": \"21321321321\"},\"request\": {\"companyCode\": 1000,        \"startDate\": \"" + checkindate.ToString("yyyy-MM-dd") + "\",        \"policyTypeCode\": 1,        \"policyCategoryCode\": \"1\",        \"quantity\": 1    }}";

            RestRequest request = new RestRequest(Method.POST);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);
            request.AddParameter("Authorization", "Bearer wfBAn5R3j5gY9h7ox/SALZXB/zhuvW9KokWEPFyEtd/eDFwyMeDMr7K/ZNiK0vjKnjq2Rwpi9xANCmRaAEI60dcO5+2rWmYvbCzDgIv5OFdfUNYEerq98bvSaapOfUHlaN1NEOnj0F9Jq+8pJPd9X3bLYl/25rOoFUlKv1cRl5KGJXHXYqUC5xQBTR9Vvl55eShscgpwRhdaCHoXpAW50LqbLFQ+A6LX6FvyjOgp+6UcBsSzhkgJUABjjMdBXfZMYUTdPBpeaEReg76LiulaZNYf39yKE8C5Z3Svub7QEwWJd/UTIvvzOZCEO7YNrPqfAJiS+XeTPjTpDkheg7w9hTEcw8mGTCI6eg5/EUbLbSaJtol+T2QRCTCbLrOX5PPd635V3X9P0WzzNdpZ/SqbxoA8Qd8y+aFBXUJGtNtSw5+cvL0Q/oW9XfOY/pESOWSTFYds51bIPZc9zcPB32pcHvkrIpk4B+oh4NzQqRZIv0/4B1cfWXH4ka353Mlq4dW77+4o5/OiuZKgp8Z6Ehv93wwLY64IYZEq5mtrNksk4G++jLgi2LPw2ks6eRnvNFkrfCO8j1I9fXYk3h3jslRdK7j5ST1OWCoy05Et6KIH7iKrqXJSfOqITQdp51z49mxc/8la7OkdP357rr+Uuegvn0KxzEkFbUWPLYdUUtdUuEccZo18kPhurTuPTJTcxaCrcGtlZX3WBvCzbyhPun8Nw11+I/MPhwUkux6s3XCzOZcbJh2lEJoyVC9wyv+CuciRyc8ekWnNFYhr+tURauuXcjBh2nnvhm2atmrN959yYXcAqZelsB95LWfzYWv7tjubDAT2fDhf79wwJ89CA9ID8ILUTF53xE7o9uCJ+xye56srdOu88cU7NGNZccMe5vj0aMf51R4BAJxaUpOI7D8y0BOt8zV3A6tsy8kgOIpkYFlDDog02ylYT3EbeRWicBBAPoxSn0GHq922c1jmgZKXty3V/tB58y2u99AsRvYEgvaY0OBh6rl4s1KXRXa0Dn1DhirOHRVw1qj1AidMR1RDdaOWCoLdWyzHEUBmROQLouM=", ParameterType.HttpHeader);
            IRestResponse response = client.Execute(request);
            string Jsonresult = response.Content;
            Console.WriteLine("*****************Insurance Search ******************************************************************");
            Console.WriteLine(Jsonresult);
            Console.WriteLine("****************************************************************************************************");
            resultVariables.Add("jsonresult", Jsonresult);
        }



    }
}
