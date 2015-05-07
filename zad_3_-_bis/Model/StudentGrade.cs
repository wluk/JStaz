using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___bis.Model
{
    public class StudentGrade
    {
        public virtual int EnrollmentID { get; set; }
        public virtual string Grade { get; set; }

        public virtual Person StudentID { get; set; }
        public virtual Course CourseID { get; set; }
    }
}
