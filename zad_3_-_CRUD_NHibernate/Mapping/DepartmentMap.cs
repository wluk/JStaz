using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_3___CRUD_NHibernate.Model;

namespace zad_3___CRUD_NHibernate.Mapping
{
    class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Id(x => x.DepartmentID).GeneratedBy.Identity();
            Map(x => x.Name);
            Map(x => x.Budget);
            Map(x => x.StartDate);
            Map(x => x.Administrator);

            HasMany<Course>(x => x.DepartmentID)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                .Inverse()
                .Generic()
                .KeyColumns.Add("DepartmentID", m => m.Name("DepartmentID").SqlType("INTEGER").Not.Nullable());

            Table("Department");
        }
    }
}
