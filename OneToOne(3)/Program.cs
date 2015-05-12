using NHibernate;
using OneToOne_3_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace OneToOne_3_
{
    class Program
    {
        private static ISession session;

        static void Main(string[] args)
        {
            session = NHibernateHelper.OpenSession();

            using (var transaction = session.BeginTransaction())
            {
                var c = new Client();
                c.profile = new Profile();
                c.profile.ProfileName = "trainee";
                c.profile.client = c;
                c.Name = "wilu";
                session.Save(c);
                var c2 = new Client();
                c2.profile = new Profile();
                c2.profile.ProfileName = "trainee";
                c2.profile.client = c2;
                c2.Name = "krbi";
                session.Save(c2);
                session.Flush();
                transaction.Commit();
                Console.WriteLine("Inser - OK");
            }
            test();
            Console.ReadLine();
        }

        private static void test()
        {
            var q = session.Query<Client>().ToList();
            Console.WriteLine();
        }
    }
}
