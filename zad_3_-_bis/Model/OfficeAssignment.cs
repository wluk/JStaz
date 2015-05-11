using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___bis.Model
{
    public class OfficeAssignment
    {
        public virtual Guid InstructorID{ get; set; }
        public virtual string Location { get; set; }
        public virtual TimeSpan Timestamp { get; set; }

        public virtual Person Person { get; set; }
    }
}
