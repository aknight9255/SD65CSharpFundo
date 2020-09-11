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
        }
    }
}
