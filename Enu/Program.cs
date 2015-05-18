using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enu
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = A.Regular;
            Console.WriteLine((int)a);

            Console.WriteLine("Pusc ten baton");
            Console.ReadLine();
        }
    }

    enum A
    {
        None = 0,
        Trivial = 1,
        Regular = 2,
    };
}
