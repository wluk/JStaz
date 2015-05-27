using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using NHibernate;
using MODEL.Model;
using SERVICES;

namespace zad_3___bis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insert
            SeedData.SeedDataStart();

            CourseInfo();
            PersonType();
            //DelAllPerson();

            Console.WriteLine("\n\nPusc ten baton...");
            Console.ReadLine();
        }

        private static void DelAllPerson()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var DBpersons = session.Query<Person>().ToList();
                foreach (var p in DBpersons)
                {
                    session.Delete(p);
                }
                session.Flush();
                session.Close();
            }
        }

        private static void DelPerson(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var p = session.Get<Person>(id);
                session.Delete(p);
                session.Flush();
                session.Close();
            }
        }

        private static List<Course> CoursesInfoByDepartment(int DepId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Course>().Where(c => c.DepartmentID.DepartmentID == DepId).ToList();
            }
        }

        private static void PersonType()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var person = session.Query<Person>().ToList();
                var student = person.Where(x => x.StudentGrades != null && x.officeAssignment == null).ToList();
                var trainer = person.Where(x => x.officeAssignment != null).ToList();

                Console.WriteLine("\nb) Wyświetlić osoby, które są");
                Console.WriteLine("Studenci");
                foreach (var s in student)
                {
                    Console.WriteLine("Imie: {0}\tnazwisko: {1}", s.FirstName, s.LastName);
                }
                Console.WriteLine("\nTrenerzy");
                foreach (var s in student)
                {
                    Console.WriteLine("Imie: {0}\tnazwisko: {1}", s.FirstName, s.LastName);
                }
                session.Close();
            }
        }

        private static void CourseInfo()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Console.WriteLine("\na) Wyświetlić wszystkie kursy wraz ze szczegółami:");
                var Depts = session.Query<Department>().ToList();
                var CoursysInfo = session.Query<Course>().ToList();
                foreach (var d in Depts)
                {
                    Console.WriteLine("Oddzial: " + d.Name);
                    foreach (var c in CoursysInfo)
                    {
                        if (!(d.DepartmentID == c.DepartmentID.DepartmentID)) continue;

                        Console.WriteLine("  * Nazwa kursu: {0}", c.Title);
                        if (c.online != null)
                        {
                            Console.WriteLine("\t- e-kurs: adres strony z kursem: {0}", c.online.URL);
                        }
                        else
                        {
                            Console.WriteLine("\t- e-kurs: brak");
                        }
                        if (c.onsite != null)
                        {
                            Console.WriteLine("\t- Szkolenie stacjonarne: Czas trwana kursu: {0} minut w sali {1}", c.onsite.Time.TotalMinutes, c.onsite.Location);
                        }
                        else
                        {
                            Console.WriteLine("\t- Szkolenie stacjonarne: brak\n\n");
                        }
                    }
                }
                session.Close();
            }

        }
    }
}