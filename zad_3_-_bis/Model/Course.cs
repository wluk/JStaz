using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3___bis.Model
{
    public class Course
    {
        public virtual int CourseID { get; set; }
        public virtual string Title { get; set; }
        public virtual int Credits { get; set; }

        public virtual Department DepartmentID { get; set; }
        public virtual OnlineCourse online { get; set; }
        public virtual OnsiteCourse onsite { get; set; }
        public virtual IList<StudentGrade> StudentGrades { get; set; }
        public virtual IList<Person> Persons { get; set; }

        public Course()
        {
            StudentGrades = new List<StudentGrade>();
            Persons = new List<Person>();
        }
    }
}
