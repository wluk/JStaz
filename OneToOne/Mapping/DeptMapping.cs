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
            Table("Department");
            LazyLoad();
            Id(x => x.DepId)
              .Column("DepId")
              .CustomType("Int32")
              .Access.Property()
              .CustomSqlType("INTEGER")
              .Not.Nullable()
              .GeneratedBy.Assigned();

            Map(x => x.DeptName);
            Map(x => x.DeptLocation);

            HasOne(x => x.Emp)
                .Class<Employee>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Constrained();
        }
    }
}
