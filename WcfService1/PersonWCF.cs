using MODEL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class PertsonWCF
    {
        [DataMember]
        public int PersonID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public DateTime? HireDate { get; set; }
        [DataMember]
        public DateTime? EnrollmentDate { get; set; }
        [DataMember]
        public bool Discrimination { get; set; }

        [DataMember]
        public OfficeAssignment officeAssignment { get; set; }
        [DataMember]
        public int StudentGradesCount { get; set; }
        [DataMember]
        public int CoursesCount { get; set; }

    }
}