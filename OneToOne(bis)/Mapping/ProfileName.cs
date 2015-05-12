using FluentNHibernate.Mapping;
using OneToOne_bis_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_bis_.Mapping
{
    class ProfileName : ClassMap<Profile>
    {
        public ProfileName()
        {
            Id(x => x.Id);
            Map(x => x.ProfileName);

            References(x => x.client).Unique();
        }
    }
}
