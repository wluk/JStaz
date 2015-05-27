using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.WCF.WCFService;

namespace UI.WCF.Controllers
{
    public class HomeController : Controller
    {
        private PersonManageClient _client;

        public HomeController()
        {
            _client = new PersonManageClient();
        }

        public ActionResult Index()
        {
            _client.Open();
            ViewBag.Msg = _client.Hello();
            _client.Close();

            return View();
        }

        public ActionResult About()
        {
            try
            {
                _client.Open();
                var persons = _client.GetAllPerson();
                ViewBag.PersonCount = persons.Count();
                _client.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}