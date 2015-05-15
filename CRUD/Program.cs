using LayerModel;
using LayerModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bee = new B
            {
                id = 8,
                name = "osiem"
            };
            Create.Add(Bee);

            Console.ReadLine();
        }
    }
}
