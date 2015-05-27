using WcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    public class PersonManage : IPersonManage
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        private CRUD _crud;

        public PersonManage()
        {
            _crud = new CRUD();
        }

        public List<PertsonWCF> GetAllPerson()
        {
            var listPerson = _crud.SelectAll();
            List<PertsonWCF> persons = new List<PertsonWCF>();
            foreach (var p in listPerson)
            {
                persons.Add(new PertsonWCF()
                {
                    CoursesCount = p.CoursesCount,
                    Discrimination = p.Discrimination,
                    EnrollmentDate = p.EnrollmentDate,
                    FirstName = p.FirstName,
                    HireDate = p.HireDate,
                    LastName = p.LastName,
                    officeAssignment = p.officeAssignment,
                    PersonID = p.PersonID,
                    StudentGradesCount = p.StudentGradesCount
                });
            }

            return persons;
        }


        public string Hello()
        {
            return "Hello, was is das WCF?";
        }
    }
}
