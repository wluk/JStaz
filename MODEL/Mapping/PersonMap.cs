﻿using FluentNHibernate.Mapping;
using MODEL.Model;

namespace MODEL.Mapping
{
    class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Table("Person");
            LazyLoad();

            Id(x => x.PersonID)
                //.Column("PersonID")
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



            HasManyToMany(x => x.Courses)
                .Cascade.All()
                .Table("CourseInstructor");

            HasOne(x => x.officeAssignment)
                .Cascade.DeleteOrphans()
                .Cascade.All();
        }
    }
}