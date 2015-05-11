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
        private static ISession session;

        static void Main(string[] args)
        {
            session = NHibernateHelper.OpenSession();

            InsertData();
            //DelAllPerson();

            session.Close();
            Console.WriteLine("\n\nPusc ten baton...");
            Console.ReadLine();
        }

        private static void InsertData()
        {
            using (var transaction = session.BeginTransaction())
            {
                try
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
                        Location = "BB",
                        Time = new TimeSpan(1, 30, 00, 00),
                        Course = c1
                    };
                    session.Save(onS1);

                    var onS2 = new OnsiteCourse
                    {
                        Days = DateTime.Now.AddDays(+3),
                        Location = "KTW",
                        Time = new TimeSpan(0, 45, 00, 00),
                        Course = c1
                    };
                    session.Save(onS2);

                    var onS3 = new OnsiteCourse
                    {
                        Days = DateTime.Now.AddDays(+4),
                        Location = "KTW",
                        Time = new TimeSpan(0, 30, 00, 00),
                        Course = c1
                    };
                    session.Save(onS3);

                    var onL1 = new OnlineCourse
                    {
                        URL = "www.google.pl",
                        Course = c2,
                    };
                    session.Save(onL1);


                    var onL2 = new OnlineCourse
                    {
                        URL = "http://mistrz-klawiatury.softonic.pl/",
                        Course = c2,
                    };
                    session.Save(onL2);

                    var s1 = new Person()
                    {
                        FirstName = "Łukasz",
                        LastName = "Wielopolski",
                        EnrollmentDate = DateTime.Now.AddDays(+1),
                        Discrimination = false,
                        OfficeAssignment = new OfficeAssignment()
                    };
                    session.Save(s1);

                    var s2 = new Person()
                    {
                        FirstName = "Krzysztof",
                        LastName = "Bizoń",
                        EnrollmentDate = DateTime.Now.AddDays(+2),
                        Discrimination = false,
                        OfficeAssignment = new OfficeAssignment()
                    };
                    session.Save(s2);

                    var t1 = new Person()
                    {
                        FirstName = "Kornel",
                        LastName = "Warwas",
                        HireDate = DateTime.Now.AddDays(-200),
                        Discrimination = true,
                        OfficeAssignment = new OfficeAssignment()
                    };
                    //c1.Persons.Add(t1);
                    t1.Courses = new List<Course>() { c1, c3, c4 };
                    session.Save(t1);

                    var t2 = new Person()
                    {
                        FirstName = "Krzysztof",
                        LastName = "Augustynek",
                        HireDate = DateTime.Now.AddDays(-175),
                        Discrimination = true,
                        OfficeAssignment = new OfficeAssignment()
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
                        Timestamp = new TimeSpan(0, 03, 00, 00),
                        Person = t1
                    };
                    session.Save(o1);

                    var o2 = new OfficeAssignment
                    {
                        Location = "BB",
                        Timestamp = new TimeSpan(0, 01, 30, 00),
                        Person = t2
                    };
                    session.Save(o2);

                    session.Flush();
                    transaction.Commit();
                    Console.WriteLine("\nInsert - ok");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nBłąd z poziomu: Insert\n" + ex);
                }
            }
        }

        private static void DelAllPerson()
        {
            var DBpersons = session.Query<Person>().ToList();
            foreach (var p in DBpersons)
            {
                DelPerson(p.PersonID);
            }
        }

        private static void DelPerson(int id)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var p = session.Get<Person>(id);
                        session.Delete(p);
                        transaction.Commit();
                        session.Close();
                        Console.WriteLine("Del - " + id);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd przy kasowaniu PersonID = " + id + "\n" + ex);

            }
        }

        //private static string SelectInstructors()
        //{
        //    string result = "";

        //    using (var session = NHibernateHelper.Opensession())
        //    {
        //        //zła strona
        //        //Person p1 = null;
        //        //OfficeAssignment o1 = null;
        //        //var q = session.QueryOver<Person>(() => p1)
        //        //    .JoinAlias(() => p1.OfficeAssignment, () => o1)
        //        //    .List<Person>();

        //        var q = from p in session.Query<Person>()
        //                join o in session.Query<OfficeAssignment>() on p.PersonID equals o.InstructorID
        //                select p;

        //        var query = q.ToList();

        //        Console.Clear();
        //        int i = 1;
        //        foreach (var instructor in query)
        //        {
        //            result += "\n\nInstruktor " + i + "\nImie: " + instructor.FirstName + "\nNazwisko: " + instructor.LastName + "\nLokalizacja: " + instructor.OfficeAssignment.Location;
        //            i++;
        //        }

        //        result += "\n\nSelect Instructor - OK";


        //        return result;
        //    }
        //}

        //private static string SelectStudents()
        //{
        //    string result = "";

        //    using (var session = NHibernateHelper.Opensession())
        //    {
        //        using (var transaction = session.BeginTransaction())
        //        {

        //            return result;
        //        }
        //    }
        //}

        //private static void DelPersons()
        //{
        //    try
        //    {
        //        using (var transaction = session.BeginTransaction())
        //        {
        //            //session.CreateQuery("DELETE * FROM Person;").ExecuteUpdate();
        //            //session.Delete(session.Load<Person>().);
        //            session.Delete("from Person p;");
        //            session.Flush();


        //            transaction.Commit();
        //            Console.WriteLine("Del - status OK");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Del - status NOT OK\n" + ex);
        //    }
        //}
        //session.CreateSQLQuery("DELETE FROM Person").ExecuteUpdate();
        //var tmp = session.CreateQuery("SELECT * FROM Course AS c LEFT JOIN OnsiteCourse AS os ON c.CourseID=os.CourseID LEFT JOIN OnlineCourse as ol ON c.CourseID = ol.CourseID;");
        //var query = from c in session.Query<Course>()
        //          join s in session.Query<OnsiteCourse>() on c.CourseID equals s.CourseID
        //          join l in session.Query<OnlineCourse>() on c.CourseID equals l.CourseID
        //          select c;
        //var query2 = query.ToList();
    }
}