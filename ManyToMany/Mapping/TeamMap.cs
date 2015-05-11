using FluentNHibernate.Mapping;
using ManyToMany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Mapping
{
    public class TeamMap : ClassMap<Team>
    {
        public TeamMap()
        {
            Not.LazyLoad();
            // identity mapping
            Id(p => p.Id);

            // column mapping
            Map(p => p.Name);

            // relationship mapping
            HasManyToMany<Employee>(m => m.Employee)
                .AsSet();
        }
    }
}
