using FluentNHibernate.Mapping;
using OneToOne_bis_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_bis_.Mapping
{
    class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);

            HasOne(x => x.profile).Cascade.All();
        }
    }
}
