using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___bis.Model
{
    public class OnlineCourse
    {
        public virtual int CourseID { get; set; }
        public virtual string URL { get; set; }

        public virtual Course Course { get; set; }
    }
}
