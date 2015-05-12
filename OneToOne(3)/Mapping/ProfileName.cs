using FluentNHibernate.Mapping;
using OneToOne_3_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_3_.Mapping
{
    class ProfileName : ClassMap<Profile>
    {
        public ProfileName()
        {
            Table("Profile");
            LazyLoad();
            Id(x => x.Id)
            .Column("Id")
            .CustomType("Int32")
            .Access.Property()
            .CustomSqlType("INTEGER")
            .Not.Nullable()
            .GeneratedBy.Foreign("client");

            Map(x => x.ProfileName);

            HasOne(x => x.client).Constrained();
        }
    }
}
