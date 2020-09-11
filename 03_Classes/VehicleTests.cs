using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Properties()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "BMW";
            firstVehicle.Model = "M850i";
            firstVehicle.Mileage = 1.8;
            firstVehicle.TypeOfVehicle = VehicleType.Tractor;
            Console.WriteLine(firstVehicle.Make);
        }
    }
}
