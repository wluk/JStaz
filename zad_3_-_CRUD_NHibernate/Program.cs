using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_3___CRUD_NHibernate.Model;

namespace zad_3___CRUD_NHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fluent NHibernate - pierwsza krew");

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        var d = new Department()
                        {
                            Name = "Oddział Bielsko-Biała",
                            Budget = 1000,
                            StartDate = DateTime.Now,
                            Administrator = "Paweł"
                        };
                        session.Save(d);

                        var c = new Course()
                        {
                            Title = "Kurs sterowania sterowcem",
                            Credits = 10,
                            DepartmentID = 0
                        };
                        session.Save(c);

                        transaction.Commit();

                        Console.WriteLine("\n\nOK");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n\n" + ex);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
