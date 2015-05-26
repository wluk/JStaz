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
        private CRUD _crud;

        public HomeController()
        {
            _crud = new CRUD();
        }

        public ActionResult Index()
        {
            var tmp_persons = _crud.SelectAll();
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
                        Discrimination = p.Discrimination,
                        CourseCount = p.CoursesCount,
                        GradeCount = p.StudentGradesCount
                    });
                i++;
            }

            return View(model);
        }

        public ActionResult EditPerson(int id)
        {
            var tmp_person = _crud.SelectById(id);
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
        public ActionResult EditPerson(VMPerson model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var p = new PersonDTO()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Discrimination = model.Discrimination,
                EnrollmentDate = model.EnrollmentDate,
                HireDate = model.HireDate,
                PersonID = model.id
            };
            _crud.Update(p);

            return RedirectToAction("Index");
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(VMPerson model)
        {
            if (!ModelState.IsValid)
                return View(model);

            PersonDTO p = new PersonDTO()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Discrimination = model.Discrimination,
                EnrollmentDate = model.EnrollmentDate,
                HireDate = model.HireDate
            };
            _crud.Create(p);
            return RedirectToAction("Index");
        }

        public ActionResult DelPerson(int id)
        {
            _crud.Delete(id);
            return RedirectToAction("Index");
        }
    }
}