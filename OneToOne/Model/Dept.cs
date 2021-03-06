﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Model
{
    public class Dept
    {
        public virtual System.Int32 DepId { get; set; }
        public virtual System.String DeptLocation { get; set; }
        public virtual System.String DeptName { get; set; }        

        public virtual OneToOne.Model.Employee Emp { get; set; }
    }
}
