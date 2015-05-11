using ManyToMany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var t1 = new Team
                        {
                            Name = "TeamA"
                        };
                        session.Save(t1);

                        var e1 = new Employee
                        {
                            FirstName = "John",
                            LastName = "Smith",
                            EMail = "'Hannibal'"
                        };
                        session.Save(e1);

                        var e2 = new Employee
                        {
                            FirstName = "Bosco Albert",
                            LastName = "Baracus",
                            EMail = "'B.A'"
                        };
                        session.Save(e2);

                        var e3 = new Employee
                        {
                            FirstName = "Templeton",
                            LastName = "Peck",
                            EMail = "'Face'"
                        };

                        t1.Employee = new List<Employee>() { e1, e2, e3 };
                        session.Save(e3);

                        var e4 = new Employee
                        {
                            FirstName = "Howling Mad",
                            LastName = "Murdock ",
                            EMail = ""
                        };
                        e4.Team.Add(t1);
                        session.Save(e4);

                        transaction.Commit();
                    }
                    session.Close();
                    Console.WriteLine("\n\nOK");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd z poziomu: programu");
                Console.ReadLine();
            }

            //Console.WriteLine("\n\nPusc ten baton");
            //Console.ReadLine();
        }
    }
}