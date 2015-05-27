using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_3___bis.Model;
using NHibernate.Linq;
using NHibernate;

namespace zad_3___bis
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertData();
            //CourseInfo();
            PersonType();
            //DelAllPerson();

            //Console.WriteLine("\n\nPusc ten baton...");
           Console.ReadLine();
        }

        private static void InsertData()
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        var d1 = new Department
                        {
                            Administrator = "Jan Kowalski",
                            Budget = 1000,
                            Name = "Bielsko",
                            StartDate = DateTime.Now
                        };
                        session.Save(d1);

                        var d2 = new Department
                        {
                            Administrator = "Adam Nowak",
                            Budget = 5000,
                            Name = "Kato",
                            StartDate = DateTime.Now.AddDays(-365)
                        };
                        session.Save(d2);

                        var c1 = new Course
                        {
                            Title = "Sterowanie sterowcem",
                            DepartmentID = d1,
                            Credits = 10
                        };
                        session.Save(c1);

                        var c2 = new Course
                        {
                            Title = "Kurs pisania na maszynie",
                            DepartmentID = d2,
                            Credits = 28
                        };
                        session.Save(c2);

                        var c3 = new Course
                        {
                            Title = "Nauka latania Latawcem",
                            DepartmentID = d1,
                            Credits = 1
                        };
                        session.Save(c3);

                        var c4 = new Course
                        {
                            Title = "Kurs wypełniania papierów unijnych",
                            DepartmentID = d2,
                            Credits = 777
                        };
                        session.Save(c4);

                        var onS1 = new OnsiteCourse
                        {
                            Days = DateTime.Now.AddDays(+3),
                            Location = "L120",
                            Time = new TimeSpan(0, 45, 00),
                            course = c1
                        };
                        c1.onsite = onS1;
                        session.Save(c1);

                        var onS2 = new OnsiteCourse
                        {
                            Days = DateTime.Now.AddDays(+3),
                            Location = "A020",
                            Time = new TimeSpan(1, 30, 00),
                            course = c2
                        };
                        c2.onsite = onS2;
                        session.Save(c2);

                        var onL1 = new OnlineCourse
                        {
                            URL = "www.google.pl",
                            course = c2,
                        };
                        c2.online = onL1;
                        session.Save(c2);


                        var onL2 = new OnlineCourse
                        {
                            URL = "http://mistrz-klawiatury.softonic.pl/",
                            course = c1,
                        };
                        c1.online = onL2;
                        session.Save(c1);

                        var s1 = new Person()
                        {
                            FirstName = "Łukasz",
                            LastName = "Wielopolski",
                            EnrollmentDate = DateTime.Now.AddDays(+1),
                            Discrimination = false
                        };
                        session.Save(s1);

                        var s2 = new Person()
                        {
                            FirstName = "Krzysztof",
                            LastName = "Bizoń",
                            EnrollmentDate = DateTime.Now.AddDays(+2),
                            Discrimination = false
                        };
                        session.Save(s2);

                        var t1 = new Person()
                        {
                            FirstName = "Kornel",
                            LastName = "Warwas",
                            HireDate = DateTime.Now.AddDays(-200),
                            Discrimination = true
                        };
                        //c1.Persons.Add(t1);
                        t1.Courses = new List<Course>() { c1, c3, c4 };
                        session.Save(t1);

                        var t2 = new Person()
                        {
                            FirstName = "Krzysztof",
                            LastName = "Augustynek",
                            HireDate = DateTime.Now.AddDays(-175),
                            Discrimination = true
                        };
                        //c2.Persons.Add(t2);
                        t2.Courses.Add(c2);
                        session.Save(t2);

                        var g1 = new StudentGrade
                        {
                            CourseID = c1,
                            StudentID = s1,
                            Grade = "dst 3"
                        };
                        session.Save(g1);

                        var g3 = new StudentGrade
                        {
                            CourseID = c3,
                            StudentID = s1,
                            Grade = "dst 3"
                        };
                        session.Save(g3);

                        var g4 = new StudentGrade
                        {
                            CourseID = c4,
                            StudentID = s1,
                            Grade = "dst 3"
                        };
                        session.Save(g4);

                        var g2 = new StudentGrade
                        {
                            CourseID = c2,
                            StudentID = s2,
                            Grade = "db 4"
                        };
                        session.Save(g2);

                        var o1 = new OfficeAssignment
                        {
                            Location = "KTW",
                            Timestamp = new TimeSpan(03, 00, 00),
                            person = t1
                        };
                        t1.officeAssignment = o1;
                        session.Save(t1);

                        var o2 = new OfficeAssignment
                        {
                            Location = "BB",
                            Timestamp = new TimeSpan(01, 30, 00),
                            person = t2
                        };
                        t2.officeAssignment = o2;
                        session.Save(t2);

                        transaction.Commit();
                        session.Flush();
                        session.Flush();
                        session.Close();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Błąd z poziomu: Insert");
            }
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