using FluentNHibernate.Mapping;
using OneToOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Mapping
{
    class EmployeeMapping : ClassMap<Employee>
    {
        public EmployeeMapping()
        {
            Id(x => x.Id).GeneratedBy.Identity(); ;
            Map(x => x.EmpName);
            Map(x => x.EmpAge);
            Map(x => x.DeptId);

            HasOne(x => x.Dept).Cascade.All();
        }
    }
}