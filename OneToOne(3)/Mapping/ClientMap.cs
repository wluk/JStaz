using FluentNHibernate.Mapping;
using OneToOne_3_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_3_.Mapping
{
    class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("Client");
            LazyLoad();
            Id(x => x.Id)
            .Column("Id")
            .CustomType("Int32")
            .Access.Property()
            .CustomSqlType("INTEGER")
            .Not.Nullable()
            .GeneratedBy.Identity();

            Map(x => x.Name);

            HasOne(x => x.profile).Cascade.All();
        }
    }
}
