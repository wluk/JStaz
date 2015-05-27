using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Client.ServiceReference;

namespace UI.Client.Controllers
{
    public class HomeController : Controller
    {
        //private ServiceReference.ServiceClient _client;
        //public HomeController()
        //{
        //    _client = new ServiceClient();
        //}

        public ActionResult Index()
        {
            //_client.Open();
            //ViewBag.Msg = _client.DoWork();
            //_client.Close();
            return View();
        }

        public ActionResult About()
        {
            //_client.Open();
            //ViewBag.Number = _client.GetAllPersons();
            //_client.Close();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}