using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public class Instructor: Person
    {
        public DateTime JoinDate { get; set; }

        public override decimal CalculateBonus()
        {
            int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
            return Salary + (yearsOfExperience * 500);
        }

       
    }
}
