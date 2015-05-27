using FluentNHibernate.Mapping;
using MODEL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Mapping
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

            Map(x => x.URL);

            HasOne(x => x.course).Constrained();
        }
    }
}
