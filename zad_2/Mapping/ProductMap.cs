using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_2.Model;

namespace zad_2.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.product_id).GeneratedBy.Identity();
            Map(x => x.name).Not.Nullable();
            Map(x => x.unit);

            References(x => x.Shopping).Column("shopping_id");
        }

    }
}
