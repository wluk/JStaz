﻿using System;
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
            Console.WriteLine(InsertData());
            Console.ReadLine();
        }

        private static string InsertData()
        {
            string result = "";
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
                            EnrollmentDate = DateTime.Now.AddDays(+1),
                            Discrimination = true
                        };
                        session.Save(s1);

                        var s2 = new Person()
                        {
                            FirstName = "Krzysztof",
                            LastName = "Bizoń",
                            EnrollmentDate = DateTime.Now.AddDays(+2),
                            Discrimination = true
                        };
                        session.Save(s2);

                        var t1 = new Person()
                        {
                            FirstName = "Kornel",
                            LastName = "Warwas",
                            HireDate = DateTime.Now.AddDays(-200),
                            Discrimination = true
                        };
                        c1.Persons.Add(t1);
                        session.Save(t1);

                        var t2 = new Person()
                        {
                            FirstName = "Krzysztof",
                            LastName = "Augustynek",
                            HireDate = DateTime.Now.AddDays(-175),
                            Discrimination = true
                        };
                        c2.Persons.Add(t2);
                        session.Save(t2);

                        var g1 = new StudentGrade
                        {
                            CourseID = c1,
                            StudentID = s1,
                            Grade = "dst 3"
                        };
                        session.Save(g1);

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
                            Timestamp = new TimeSpan(1, 00, 00, 00),
                            Person = t1
                        };
                        session.Save(o1);

                        var o2 = new OfficeAssignment
                        {
                            Location = "BB",
                            Timestamp = new TimeSpan(2, 30, 00, 00),
                            Person = t2
                        };
                        session.Save(o2);

                        transaction.Commit();
                        result = "\n\nOK";
                    }
                    catch (Exception ex)
                    {
                        result = "Błąd z poziomu: programu";
                    }
                }
                return result;
            }            
        }
    }
}