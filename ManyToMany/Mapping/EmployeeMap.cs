using FluentNHibernate.Mapping;
using ManyToMany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Mapping
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Not.LazyLoad();
            // identifier mapping
            Id(p => p.Id);

            // column mapping
            Map(p => p.EMail);
            Map(p => p.LastName);
            Map(p => p.FirstName);

            // relationship mapping
            HasManyToMany<Team>(m => m.Team)
                .Inverse()
                .AsSet();
        }
    }
}