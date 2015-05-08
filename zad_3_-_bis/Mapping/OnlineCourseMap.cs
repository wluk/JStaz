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
            Id(x => x.CourseID).GeneratedBy.Identity();
            Map(x => x.URL);

            HasOne(x => x.Course).Constrained();
        }
    }
}
