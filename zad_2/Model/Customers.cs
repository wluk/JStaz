using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2.Model
{
    public class Customers
    {
        public virtual int customer_id { get; protected set; }
        public virtual string name { get; set; }
        public virtual string email { get; set; }
        public virtual string contact_person { get; set; }
        public virtual string postal_address { get; set; }
        public virtual string physical_address { get; set; }
        public virtual string contact_number { get; set; }
        public virtual int employee_id { get; set; }
        public virtual DateTime date_created { get; set; }
        public virtual DateTime date_updated { get; set; }
        public virtual string created_from_ip { get; set; }
        public virtual string updated_from_ip { get; set; }
    }
}
