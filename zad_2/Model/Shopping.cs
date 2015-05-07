using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2.Model
{
    public class Shopping
    {
        public virtual int shopping_id { get; protected set; }
        public virtual DateTime date_shopping { get; set; }
        public virtual IList<Product> products { get; set; }

        public Shopping()
        {
            products = new List<Product>();
        }
    }
}
