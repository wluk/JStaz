using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    public class FirstService : IFirstService
    {
        public string DoWork()
        {
            return string.Format("Was is das WCF, kein halt {0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
        }

        public List<int> IntList()
        {
            return new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }
}
