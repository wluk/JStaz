using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Model
{
    public class Person
    {
        public virtual int PersonID { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual DateTime? HireDate { get; set; }
        public virtual DateTime? EnrollmentDate { get; set; }
        public virtual bool Discrimination { get; set; }

        public virtual OfficeAssignment officeAssignment { get; set; }
        public virtual IList<StudentGrade> StudentGrades { get; set; }
        public virtual IList<Course> Courses { get; set; }

        public Person()
        {
            StudentGrades = new List<StudentGrade>();
            Courses = new List<Course>();
        }
    }
}
