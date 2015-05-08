using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SERVICE;
using UI.Web.ViewModel;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var tmp_persons = SELECT.SelectAllPerson();
            var model = new List<VMPerson>();
            int i = 0;
            foreach (var p in tmp_persons)
            {
                model.Add(new VMPerson()
                    {
                        id = p.PersonID,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        EnrollmentDate = p.EnrollmentDate,
                        HireDate = p.HireDate,
                        Discrimination = p.Discrimination
                    });
                i++;
            }

            return View(model);
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        public ActionResult EditPerson(int id)
        {
            var tmp_person = SELECT.SelectPersonById(id);
            VMPerson model = new VMPerson()
            {
                id = tmp_person.PersonID,
                FirstName = tmp_person.FirstName,
                LastName = tmp_person.LastName,
                EnrollmentDate = tmp_person.EnrollmentDate,
                HireDate = tmp_person.HireDate,
                Discrimination = tmp_person.Discrimination
            };


            return View(model);
        }

        [HttpPost]
        public ActionResult AddPerson(VMPerson model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditPerson(VMPerson model)
        {
            //var tmp_person = SELECT.SelectPersonById(id);
            //VMPerson model = new VMPerson()
            //{
            //    id = tmp_person.PersonID,
            //    FirstName = tmp_person.FirstName,
            //    LastName = tmp_person.LastName,
            //    EnrollmentDate = tmp_person.EnrollmentDate,
            //    HireDate = tmp_person.HireDate,
            //    Discrimination = tmp_person.Discrimination
            //};
            return View(model);
        }
    }
}