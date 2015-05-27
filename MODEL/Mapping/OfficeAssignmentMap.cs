using FluentNHibernate.Mapping;
using MODEL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Mapping
{
    class OfficeAssignmentMap : ClassMap<OfficeAssignment>
    {
        public OfficeAssignmentMap()
        {
            Id(x => x.InstructorID)
                .GeneratedBy.Foreign("person")
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

            HasOne(x => x.person).Constrained();

        }
    }
}
