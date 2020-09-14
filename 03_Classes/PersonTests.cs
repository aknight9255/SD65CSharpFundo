using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person firstPerson = new Person("Howard", "Stefanopoulous", new DateTime(1785,02,14), new Vehicle());
            Console.WriteLine(firstPerson);
            Console.WriteLine(firstPerson.Age);
            int anotherAge = firstPerson.Age;
            firstPerson.Transport.Make = "A New Car!";
            firstPerson.Transport.Model = "Blue";
            firstPerson.Transport.Mileage = 2;
            firstPerson.Transport.TypeOfVehicle = VehicleType.FlyingBison;

            Assert.AreEqual("Howard Stefanopoulous", firstPerson.FullName);
            

        }
    }
}
