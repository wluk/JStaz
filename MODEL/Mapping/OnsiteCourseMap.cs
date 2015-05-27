using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Model
{
    class OnsiteCourseMap : ClassMap<OnsiteCourse>
    {
        public OnsiteCourseMap()
        {
            Id(x => x.CourseID)
                .Column("CourseID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()
                .GeneratedBy.Foreign("course");
            Map(x => x.Location);
            Map(x => x.Days);
            Map(x => x.Time).CustomType("TimeAsTimeSpan");

            HasOne(x => x.course).Constrained();
        }
    }
}
