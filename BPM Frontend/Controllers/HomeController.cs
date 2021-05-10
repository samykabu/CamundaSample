using CamundaClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace BPM_Frontend.Controllers
{
    public class HomeController : Controller
    {
        CamundaEngineClient camunda = new CamundaEngineClient();
        public HomeController()
        {
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View("Index","");
        }

        [HttpPost]
        public ActionResult Index(DateTime startDate, DateTime endDate)
        {
            var processResponse = camunda.BpmnWorkflowService.StartProcessInstanceSync(
                "hotelsearchProcess",
                "hotelsearchProcess",
                new Dictionary<string, object> {
                    {"checkindate",startDate },
                    {"checkoutdate",endDate },
                });
           var result=camunda.BpmnWorkflowService.waitForProcessCompletetion(processResponse.Id);

            if (processResponse.Ended)
{
}

            return View("Index",result.SingleOrDefault(e=>e.name== "jsonresult").value);
        }
    }
}
