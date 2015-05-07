using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2.Model
{
    public class Product
    {
        public virtual int product_id { get; protected set; }
        public virtual string name { get; set; }
        public virtual string unit { get; set; }

        public virtual Shopping Shopping { get; set; }
    }
}
