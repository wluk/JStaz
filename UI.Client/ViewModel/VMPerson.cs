using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Client.ViewModel
{
    public class VMPerson
    {
        //[Required]
        public int id { get; set; }

        //[Required]
        [Display(Name = "Imie: ")]
        public string FirstName { get; set; }

        //[Required]
        [Display(Name = "Nazwisko: ")]
        public string LastName { get; set; }

        [Display(Name = "Data zatrudnienia: ")]
        public DateTime? HireDate { get; set; }

        [Display(Name = "Data przystąpienia: ")]
        public DateTime? EnrollmentDate { get; set; }

        //[Required]
        [Display(Name = "Cosik: ")]
        public bool Discrimination { get; set; }

        [Display(Name = "Liczba szkoleń: ")]
        public int CourseCount { get; set; }

        [Display(Name = "Liczba kursów: ")]
        public int GradeCount { get; set; }
    }
}