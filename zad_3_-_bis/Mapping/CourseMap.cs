using FluentNHibernate.Mapping;
using zad_3___bis.Model;

namespace zad_3___bis.Mapping
{
    class CourseMap : ClassMap<Course>
    {
        public CourseMap()
        {
            Table("Course");
            LazyLoad();

            Id(x => x.CourseID)
              .Column("CourseID")
            .CustomType("Int32")
            .Access.Property()
            .CustomSqlType("INTEGER")
            .Not.Nullable()
            .GeneratedBy.Identity();

            Map(x => x.Title)
              .CustomType("AnsiString")
                .Length(50)
                .Column("Title")
                .Access.Property()
                .Generated.Never();

            Map(x => x.Credits)
                .Column("Credits")
                .CustomType("Int32")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("INTEGER");

            References(x => x.DepartmentID, "DeptId")
                .Cascade.None();

            HasOne(x => x.online)
                .Cascade.All();

            HasOne(x => x.onsite)
                .Cascade.All();

            HasMany(x => x.StudentGrades)
                .KeyColumn("CourseID")
                .Inverse()
                .Cascade.All();

            HasManyToMany(x => x.Persons)
                .Cascade.All()
                .Inverse()
                .Table("CourseInstructor");
        }
    }
}