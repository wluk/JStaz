using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_bis_.Model
{
    public class Profile
    {
        public virtual int Id { get; set; }
        public virtual string ProfileName { get; set; }

        public virtual Client client { get; set; }
    }
}
