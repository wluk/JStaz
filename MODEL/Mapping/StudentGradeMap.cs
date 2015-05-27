using FluentNHibernate.Mapping;
using MODEL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Mapping
{
    class StudentGradeMap : ClassMap<StudentGrade>
    {
        public StudentGradeMap()
        {
            Table("StudentGrade");
            LazyLoad();

            Id(x => x.EnrollmentID)
              .Column("EnrollmentID")
              .CustomType("Int32")
              .Access.Property()
              .CustomSqlType("INTEGER")
              .Not.Nullable()
              .GeneratedBy.Identity();

            Map(x => x.Grade)
              .CustomType("AnsiString")
                .Length(50)
                .Column("Grade")
                .Access.Property()
                .Generated.Never();

            References(x => x.StudentID, "StudentID")
                .Cascade.None();
            References(x => x.CourseID, "CourseID").Cascade.None();
        }
    }
}
