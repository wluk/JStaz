using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new ContextTak())
                {
                    db.As.Add(new A
                    {
                        id = 8,
                        name = "osiem"
                    });
                    db.SaveChanges();
                    Console.WriteLine("OK");
                }
            }
            catch (Exception)
            {
                Console.WriteLine(":(");
            }
            Console.ReadLine();
        }
    }
}
