using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NHibernate.Linq;
using SERVICE;
using MODEL.Model;

namespace WCFWebService
{
    public class WCFWebService : IWCFWebService
    {
        public string Msg()
        {
            return "Hello, was is das WCF?";
        }

        public List<SERVICE.PersonDTO> PersonList()
        {
            var persons = new List<PersonDTO>();
            using (var session = NHibernateHelper.OpenSession())
            {
                var DBpersons = session.Query<Person>().ToList();
                foreach (var p in DBpersons)
                {
                    persons.Add(new PersonDTO()
                    {
                        PersonID = p.PersonID,
                        LastName = p.LastName,
                        HireDate = p.HireDate,
                        FirstName = p.FirstName,
                        EnrollmentDate = p.EnrollmentDate,
                        Discrimination = p.Discrimination,
                        CoursesCount = p.Courses.Count(),
                        officeAssignment = null,
                        StudentGradesCount = p.StudentGrades.Count()
                    });
                }
                session.Close();
            }
            return persons;
        }
    }
}
