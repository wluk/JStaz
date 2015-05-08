using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___CRUD_NHibernate.Model
{
    public class Course
    {
        public virtual int CourseID { get; set; }
        public virtual string Title { get; set; }
        public virtual int Credits { get; set; }
        public virtual int DepartmentID { get; set; }
    }
}
