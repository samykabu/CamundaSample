using CamundaClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BPM_Frontend.Controllers
{
    public class HomeController : Controller
    {
        CamundaEngineClient camunda = new CamundaEngineClient(new Uri("http://10.1.64.82:8080/engine-rest/"), "", "");
        public HomeController()
        {
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View("Index", "");
        }

        [HttpPost]
        public ActionResult Index(DateTime startDate)//, DateTime endDate)
        {
            var processResponse = camunda.BpmnWorkflowService.StartProcessInstanceSync(
                "hotelsearchProcess",
                "hotelsearchProcess",
                new Dictionary<string, object> {
                    {"checkindate",startDate },
                    {"checkoutdate",DateTime.MaxValue },
                });
            var result = camunda.BpmnWorkflowService.waitForProcessCompletetion(processResponse.Id);

            if (processResponse.Ended)
            {
            }

            return View("Index", result.SingleOrDefault(e => e.name == "jsonresult").value);
        }
    }
}
