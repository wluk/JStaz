using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public virtual int PersonID { get; set; }

        [DataMember]
        public virtual string LastName { get; set; }

        [DataMember]
        public virtual string FirstName { get; set; }

        [DataMember]
        public virtual DateTime? HireDate { get; set; }

        [DataMember]
        public virtual DateTime? EnrollmentDate { get; set; }

        [DataMember]
        public virtual bool Discrimination { get; set; }
    }

    public partial class Persons
    {
        private static readonly Persons _instance = new Persons();

        private Persons() { }

        public static Persons Instance
        {
            get { return _instance; }
        }
        public List<Person> ProductList
        {
            get { return products; }
        }
        private List<Person> products = new List<Person>() 
        { 
            new Person() {Discrimination = true, EnrollmentDate= DateTime.Now.AddDays(365), FirstName="Janko", LastName="Muzykant", PersonID = 1 },
            new Person() {Discrimination = true, EnrollmentDate= DateTime.Now.AddDays(365), FirstName="Adam", LastName="Nowak", PersonID = 2 },
            new Person() {Discrimination = true, EnrollmentDate= DateTime.Now.AddDays(365), FirstName="Janko", LastName="Muzykant", PersonID = 3 },
            new Person() {Discrimination = true, EnrollmentDate= DateTime.Now.AddDays(365), FirstName="Janko", LastName="Muzykant", PersonID = 4 },
            new Person() {Discrimination = true, EnrollmentDate= DateTime.Now.AddDays(365), FirstName="Janko", LastName="Muzykant", PersonID = 5 }
        };
    }
}