using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_3___bis.Model;

namespace zad_3___bis.Mapping
{
    class OnlineCourseMap : ClassMap<OnlineCourse>
    {
        public OnlineCourseMap()
        {
            Id(x => x.CourseID)
                .Column("CourseID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()
                .GeneratedBy.Foreign("course");

            HasOne(x => x.course).Constrained();
        }
    }
}
