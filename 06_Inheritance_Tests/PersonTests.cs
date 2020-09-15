using System;
using System.Collections.Generic;
using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.SetFirstName("Martha");
            martha.SetLastName("Vineyard");
            Console.WriteLine(martha.Name);

            Customer bob = new Customer();
            bob.SetFirstName("Bobert");
            bob.SetLastName("Boss");

            SalaryEmployee tedEmployee = new SalaryEmployee
            {
                PhoneNumber = "1800-fakenumber",
                Salary = 800000,
                HireDate = new DateTime(1304, 01, 01),
                EmployeeNumber = 394
            };
            Console.WriteLine(tedEmployee.YearsWithCompany);

        }

        [TestMethod]
        public void EmployeeTestsAKAStarkTower()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            tony.HoursWorked = 55;
            tony.HourlyWage = 3000;
            pepper.Salary = 200000;
            HourlyEmployee peter = new HourlyEmployee();
            SalaryEmployee happy = new SalaryEmployee();
            happy.Salary = 150000;
            List<Employee> allEmployees = new List<Employee>();
            jarvis.SetFirstName("Jarvis");
            tony.SetFirstName("Tony");
            pepper.SetFirstName("Pepper");
            peter.SetFirstName("Peter");
            happy.SetFirstName("Happy");
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper);
            allEmployees.Add(peter);
            allEmployees.Add(happy);


            foreach(Employee worker in allEmployees)
            {
                
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.Salary}");
                }
                else if (worker is HourlyEmployee hourlyWorker)
                {
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }
        }
    }
}
