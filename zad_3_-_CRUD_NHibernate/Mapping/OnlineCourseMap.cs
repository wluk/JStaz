//using FluentNHibernate.Mapping;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using zad_3___CRUD_NHibernate.Model;

//namespace zad_3___CRUD_NHibernate.Mapping
//{
//    class OnlineCourseMap : ClassMap<OnlineCourse>
//    {
//        public OnlineCourseMap()
//        {
//            Id(x => x.CourseID).GeneratedBy.Identity();
//            Map(x => x.URL);

//            References(x => x.CourseID).Unique();
//        }
//    }
//}
