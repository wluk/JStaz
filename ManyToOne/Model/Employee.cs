using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToOne.Model
{
    public class Employee
    {
        public virtual System.Int32 DeptId { get; set; }
        public virtual System.Int32 EmpAge { get; set; }
        public virtual System.String EmpName { get; set; }
        public virtual System.Int32 Id { get; set; }

        public virtual ManyToOne.Model.Dept Dept { get; set; }
    }
}
