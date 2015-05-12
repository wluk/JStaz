using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___bis.Model
{
    public class OnsiteCourse
    {
        public virtual int CourseID { get; set; }
        public virtual string Location { get; set; }
        public virtual DateTime Days { get; set; }
        public virtual TimeSpan Time { get; set; }

        public virtual Course course { get; set; }
    }
}
