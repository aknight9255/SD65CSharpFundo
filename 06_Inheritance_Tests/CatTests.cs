using System;
using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Inheritance_Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void CatTesting()
        {
            //Animal firstAnimal = new Animal();
            Console.WriteLine("Break");
            Cat firstCat = new Cat();
            Console.WriteLine("Break");
            //firstAnimal.Move();
            Console.WriteLine("Break");
            firstCat.Move();
            Console.WriteLine("Break");
            firstCat.MakeSound();
            Console.WriteLine("Break");
            Liger oneLiger = new Liger();
            Console.WriteLine("Break");
            oneLiger.Move();
            Console.WriteLine("Break");
            oneLiger.MakeSound();
            //Try making other classes that inherit from the animal class 
        }
    }
}
