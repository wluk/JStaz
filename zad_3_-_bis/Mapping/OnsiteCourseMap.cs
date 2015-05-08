using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___bis.Model
{
    class OnsiteCourseMap : ClassMap<OnsiteCourse>
    {
        public OnsiteCourseMap()
        {
            Id(x => x.CourseID).GeneratedBy.Identity();
            Map(x => x.Location);
            Map(x => x.Days);
            Map(x => x.Time).CustomType("TimeAsTimeSpan");

            HasOne(x => x.Course).Constrained();
        }
    }
}
