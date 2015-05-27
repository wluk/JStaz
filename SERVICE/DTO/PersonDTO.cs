using MODEL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class PersonDTO
    {
        public virtual int PersonID { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual DateTime? HireDate { get; set; }
        public virtual DateTime? EnrollmentDate { get; set; }
        public virtual bool Discrimination { get; set; }

        public virtual OfficeAssignment officeAssignment { get; set; }
        public virtual int StudentGradesCount { get; set; }
        public virtual int CoursesCount { get; set; }

    }
}