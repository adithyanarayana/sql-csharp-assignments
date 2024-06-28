using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        private decimal salary;
        public string[] Addresses { get; set; }


        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative");
                salary = value;
            }
        }

        public abstract decimal CalculateBonus();

        public int CalculateAge()
        {
            var age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                age--;

            return age;
        }

       
    }
}
