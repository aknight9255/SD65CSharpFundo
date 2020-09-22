using System;
using System.Collections.Generic;
using _09_Interfaces_Introduction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            var output = banana.Peel();
            Console.WriteLine(output);
            Banana bananaTwo = new Banana();
            var anotherOutput = bananaTwo.Peel();
            Console.WriteLine(anotherOutput);
        }
        [TestMethod]
        public void InterfacesInCollections()
        {
            var orangeObject = new Orange();
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                new Orange(true),
                orangeObject
            };

            foreach(var oneFruit in fruitSalad)
            {
                Console.WriteLine(oneFruit.Name);
                Console.WriteLine(oneFruit.Peel());
                Assert.IsInstanceOfType(oneFruit, typeof(IFruit));
                Assert.IsInstanceOfType(orangeObject, typeof(Orange));
            }
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}."; 
        }
        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);
        }
    }
}
