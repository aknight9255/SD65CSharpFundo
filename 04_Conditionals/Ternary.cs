using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;
            //(conditional/Boolean) ? trueResult : falseResult;
            bool isAdult = (age > 17) ? true : false;

            int numOne = 11; //UserInput 
            string output = (numOne == 10) ? "You guessed correctly" : "You did not guess correctly";
            Console.WriteLine((output == "You guessed correctly") ? "Congrats" : "Try Again");
        }
    }
}
