using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_2.Model;

namespace zad_2.Mapping
{
    class ShoppingMap : ClassMap<Shopping>
    {
        public ShoppingMap()
        {
            Id(x => x.shopping_id).GeneratedBy.Identity();
            Map(x => x.date_shopping);

            HasMany(m => m.products).Cascade.All();
        }
    }
}
