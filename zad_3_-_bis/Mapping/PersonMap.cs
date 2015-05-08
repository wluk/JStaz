using FluentNHibernate.Mapping;
using zad_3___bis.Model;

namespace zad_3___bis.Mapping
{
    class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Table("Person");
            LazyLoad();

            Id(x => x.PersonID)
              .Column("PersonID")
              .CustomType("Int32")
              .Access.Property()
              .CustomSqlType("INTEGER")
              .Not.Nullable()
              .GeneratedBy.Identity();

            Map(x => x.LastName)
              .CustomType("AnsiString")
                .Length(50)
                .Column("LastName")
                .Access.Property()
                .Generated.Never();

            Map(x => x.FirstName)
              .CustomType("AnsiString")
                .Length(50)
                .Column("FirstName")
                .Access.Property()
                .Generated.Never();

            Map(x => x.HireDate)
                .CustomSqlType("datetime2");

            Map(x => x.EnrollmentDate)
                .CustomSqlType("datetime2");

            Map(x => x.Discrimination);

            HasOne(x => x.OfficeAssignment).Cascade.All();
            HasManyToMany(x => x.Courses).Cascade.All().Table("CourseInstructor");

        }
    }
}