using OneToOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
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
                        var d = new Dept
                        {
                            DeptLocation = "BB",
                            DeptName = "Biuro Bielsko",
                            Employee = new Employee
                                {
                                    EmpAge = 8,
                                    EmpName = "wilu",                                    
                                }
                            
                        };

                        session.Save(d);

                        transaction.Commit();
                        Console.WriteLine("OK");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Błąd z poziomu: programu");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
