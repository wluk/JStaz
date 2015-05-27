using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Model
{
    public class OfficeAssignment
    {
        public virtual int InstructorID{ get; set; }
        public virtual string Location { get; set; }
        public virtual TimeSpan Timestamp { get; set; }

        public virtual Person person { get; set; }
    }
}
