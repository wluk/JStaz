using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Model
{
    public class Employee
    {
        public virtual System.Int32 EmpAge { get; set; }
        public virtual System.String EmpName { get; set; }
        public virtual System.Int32 EmpId { get; set; }

        public virtual OneToOne.Model.Dept Dept { get; set; }
    }
}
