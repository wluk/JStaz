using MODEL.Model;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class CRUD : ICRUD<PersonDTO>
    {
        public void Create(PersonDTO person)
        {
            var p = new Person
            {
                Courses = null,
                Discrimination = person.Discrimination,
                EnrollmentDate = person.EnrollmentDate,
                FirstName = person.FirstName,
                HireDate = person.HireDate,
                LastName = person.LastName,
                officeAssignment = null,
                StudentGrades = null
            };
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(p);
                    transaction.Commit();
                    session.Flush();
                    session.Close();
                }
            }
        }

        public void Update(PersonDTO person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var personUpdate = session.Get<MODEL.Model.Person>(person.PersonID);

                personUpdate.FirstName = person.FirstName;
                personUpdate.LastName = person.LastName;
                personUpdate.Discrimination = person.Discrimination;
                personUpdate.EnrollmentDate = person.EnrollmentDate;
                personUpdate.HireDate = person.HireDate;
                personUpdate.PersonID = personUpdate.PersonID;

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(personUpdate);
                    transaction.Commit();
                    session.Flush();
                }
                session.Close();
            }
        }

        public void Delete(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var p = session.Get<Person>(id);
                session.Delete(p);
                session.Flush();
                session.Close();
            }
        }

        public List<PersonDTO> SelectAll()
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
                        officeAssignment = p.officeAssignment,
                        StudentGradesCount = p.StudentGrades.Count()
                    });
                }
                session.Close();
            }
            return persons;
        }

        public PersonDTO SelectById(int id)
        {
            var person = new PersonDTO();
            using (var session = NHibernateHelper.OpenSession())
            {
                var p = session.Get<Person>(id);
                //session.Close();

                if (p != null)
                {
                    return new PersonDTO()
                    {
                        CoursesCount = p.Courses.Count(),
                        Discrimination = p.Discrimination,
                        EnrollmentDate = p.EnrollmentDate,
                        FirstName = p.FirstName,
                        HireDate = p.HireDate,
                        LastName = p.LastName,
                        officeAssignment = p.officeAssignment,
                        PersonID = p.PersonID,
                        StudentGradesCount = p.StudentGrades.Count()
                    };
                }
            }
            return null;
        }
    }
}
