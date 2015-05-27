using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFClient.ServiceReference;

namespace WCFClient.Controllers
{
    public class HomeController : Controller
    {
        WCFWebServiceClient client = new WCFWebServiceClient();

        public ActionResult Index()
        {          

            return View();
        }

        public ActionResult Clik()
        {
            ViewBag.message = client.Msg();
            var persons = client.PersonList();

            return View();
        }

    }
}