using FluentNHibernate.Mapping;
using OneToOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Mapping
{
    class DeptMapping : ClassMap<Dept>
    {
        public DeptMapping()
        {
            Id(x => x.Id).GeneratedBy.Identity(); ;
            Map(x => x.DeptName);
            Map(x => x.DeptLocation);

            HasOne(x => x.Employee).Constrained();
        }
    }
}
