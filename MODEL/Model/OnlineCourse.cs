using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Model
{
    public class OnlineCourse
    {
        public virtual int CourseID { get; set; }
        public virtual string URL { get; set; }

        public virtual Course course { get; set; }
    }
}
