using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToOne
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
                        

                        transaction.Commit();
                        Console.WriteLine("OK");
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
