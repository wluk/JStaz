using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Client.ServiceReference;
using SERVICES;
using UI.Client.ViewModel;

namespace UI.Client.Controllers
{
    public class HomeController : Controller
    {
        private ServiceReference.ToDoClient _client;
        public HomeController()
        {
            _client = new ToDoClient();
        }

        public ActionResult Index()
        {
            //_client.Open();
            //ViewBag.Msg = _client.DoWork();
            //_client.Close();
            return View();
        }

        public ActionResult About()
        {
            _client.Open();
            var persons = _client.GetToDos();
            List<VMPerson> personListModel = new List<VMPerson>();
            foreach (var p in persons)
            {
                personListModel.Add(new VMPerson() { id = p.Id, FirstName = p.FirstName, LastName = p.LastName });
            }
            _client.Abort();
            _client.Close();

            return View(personListModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}