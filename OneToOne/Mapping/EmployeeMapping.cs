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
            Table("Employee");
            LazyLoad();
            Id(x => x.EmpId)
              .Column("EmpId")
              .CustomType("Int32")
              .Access.Property()
              .CustomSqlType("INTEGER")
              .Not.Nullable()
              .GeneratedBy.Identity();
            Map(x => x.EmpName);
            Map(x => x.EmpAge);
            Map(x => x.Dept);

            HasOne(x => x.Dept)
                .Class<Dept>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad();
        }
    }
}