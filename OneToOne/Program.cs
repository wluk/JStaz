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
                        var d1 = new Dept
                        {
                            DeptLocation = "BB",
                            DeptName = "Biuro Bielsko",
                            Emp = new Employee
                                {
                                    EmpAge = 8,
                                    EmpName = "wilu",
                                }
                        };
                        var d2 = new Dept
                        {
                            DeptLocation = "KTW",
                            DeptName = "Biuro Kato",
                            Emp = new Employee
                            {
                                EmpAge = 16,
                                EmpName = "xyz",
                            }
                        };

                        session.Save(d1, d2);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Błąd z poziomu: programu\n" + ex);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
