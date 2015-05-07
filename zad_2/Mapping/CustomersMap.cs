using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_2.Model;

namespace zad_2.Mapping
{
    class CustomersMap : ClassMap<Customers>
    {
        public CustomersMap()
        {
            Id(x => x.customer_id);
            Map(x => x.name);
            Map(x => x.email);
            Map(x => x.contact_person);
            Map(x => x.postal_address);
            Map(x => x.physical_address);
            Map(x => x.contact_number);

            Map(x => x.employee_id);
            Map(x => x.date_created);
            Map(x => x.date_updated);
            Map(x => x.created_from_ip);
            Map(x => x.updated_from_ip);
        }
    }
}
