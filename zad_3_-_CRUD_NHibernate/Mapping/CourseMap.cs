using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_3___CRUD_NHibernate.Model;

namespace zad_3___CRUD_NHibernate.Mapping
{
    class CourseMap : ClassMap<Course>
    {
        public CourseMap()
        {
            Id(x => x.CourseID).GeneratedBy.Identity();
            Map(x => x.Title);
            Map(x => x.Credits);
            Map(x => x.DepartmentID);

            References(x => x.DepartmentID)
                .Class<Department>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Columns("DepartmentID");

            Table("Course");
        }
    }
}
