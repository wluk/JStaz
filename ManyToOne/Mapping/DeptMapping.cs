using FluentNHibernate.Mapping;
using ManyToOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToOne.Mapping
{
    class DeptMapping : ClassMap<Dept>
    {
        public DeptMapping()
        {
            Id(x => x.Id).GeneratedBy.Identity(); ;
            Map(x => x.DeptName);
            Map(x => x.DeptLocation);

            HasMany(x => x.Employees).KeyColumn("DeptId").Inverse().Cascade.All();
        }
    }
}
