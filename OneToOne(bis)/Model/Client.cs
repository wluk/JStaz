using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_bis_.Model
{
    public class Client
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual Profile profile { get; set; }
    }
}
