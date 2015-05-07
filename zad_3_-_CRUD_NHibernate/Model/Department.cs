using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___CRUD_NHibernate.Model
{
    public class Department
    {
        public virtual int DepartmentID { get; set; }
        public virtual string Name { get; set; }
        public virtual float Budget { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual string Administrator { get; set; }
    }
}
