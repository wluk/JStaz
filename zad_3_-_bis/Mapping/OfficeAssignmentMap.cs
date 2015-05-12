﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad_3___bis.Model;

namespace zad_3___bis.Mapping
{
    class OfficeAssignmentMap : ClassMap<OfficeAssignment>
    {
        public OfficeAssignmentMap()
        {
            Id(x => x.InstructorID)
                //.GeneratedBy.Foreign("Person");
            .Column("InstructorID")
            .CustomType("Int32")
            .Access.Property()
            .CustomSqlType("INTEGER")
            .Not.Nullable();

            Map(x => x.Location)
              .CustomType("AnsiString")
                .Length(50)
                .Column("Location")
                .Access.Property()
                .Generated.Never();

            Map(x => x.Timestamp)
                .CustomType("TimeAsTimeSpan");

            HasOne(x => x.Person)
                .Class<Person>()
                .Access.Property()
                .Cascade.None();
            //HasOne(x => x.Person).Constrained();
                //.Class<Person>()
                //.Access.Property()
                //.Cascade.None()
                //.Constrained();

        }
    }
}
