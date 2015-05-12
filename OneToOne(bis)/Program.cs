using OneToOne_bis_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_bis_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                //Console.WriteLine("\n" + session.Statistics.ToString());
                using (var transaction = session.BeginTransaction())
                {
                    var c = new Client()
                    {
                        Name = "wilu"
                    };
                    c.profile = new Profile()
                    {
                        client = c,
                        ProfileName = "Tak"
                    };
                    session.Save(c);

                    session.Flush();
                    transaction.Commit();
                    Console.WriteLine("Inser - OK");
                }
            }
            Console.ReadLine();
        }
    }
}
