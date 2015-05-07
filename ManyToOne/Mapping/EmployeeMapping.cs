using FluentNHibernate.Mapping;
using ManyToOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToOne.Mapping
{
    class EmployeeMapping : ClassMap<Employee>
    {
        public EmployeeMapping()
        {
            Id(x => x.Id).GeneratedBy.Identity(); ;
            Map(x => x.EmpName);
            Map(x => x.EmpAge);
            Map(x => x.DeptId);

            References(x => x.Dept, "DeptId").Cascade.None();
        }
    }
}