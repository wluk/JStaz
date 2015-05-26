using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_host
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(SERVICES_WCF.PersonManage)))
            {
                host.Open();
                Console.WriteLine("Host start at {0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());

            }
        }
    }
}
