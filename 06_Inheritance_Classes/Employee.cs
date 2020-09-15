using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        }
    }

    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}
