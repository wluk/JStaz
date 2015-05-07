using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_3___bis.Model;

namespace zad_3___bis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
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
                            EnrollmentDate = DateTime.Now.AddDays(+1)
                        };

                        transaction.Commit();
                        Console.WriteLine("\n\n\nOK");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Błąd z poziomu: programu");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
