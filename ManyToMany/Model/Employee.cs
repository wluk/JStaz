using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public String LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Team> Team { get; set; }
        public string EMail { get; set; }
        public Employee() 
        { 
            Team = new List<Team>(); 
        }
    }
}
