using System;
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
        }
    }
}
