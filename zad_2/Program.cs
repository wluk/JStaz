using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_2.Model;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fluent NHibernate - pierwsza krew");
            using (var session = NHibernateHelper.OpenSession())
            {
                var c = new Customers
                {
                    name = "Biedronka",
                    email = "biuro@biedronka.pl",
                    contact_person = "Pan Kaziu",
                    postal_address = "Sklep Biedronka, ul. Prof. M.Michałowicza 12, 43-300 BB",
                    physical_address = "ul. Prof. M.Michałowicza 12, 43-300 BB",
                    contact_number = "800 080 010",
                    employee_id = 8,
                    date_created = DateTime.Now,
                    date_updated = DateTime.Now,
                    created_from_ip = "127.0.0.1",
                    updated_from_ip = "127.0.0.1"
                };
                session.Save(c);
                try
                {
                    var s = new Shopping() { date_shopping = DateTime.Now };
                    session.Save(s);

                    var p1 = new Product() { name = "ziemniaki", unit = "kg", Shopping = s };
                    s.products.Add(p1);
                    session.Save(p1);

                    var p2 = new Product() { name = "kokos", unit = "szt", Shopping = s };
                    s.products.Add(p2);
                    session.Save(p2);


                    Console.WriteLine("\n\nOK");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            Console.ReadLine();
        }
    }
}
