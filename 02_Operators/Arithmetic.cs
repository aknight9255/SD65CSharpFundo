using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 13;
            int b = 74;

            int sum = a + b;
            Console.WriteLine(sum);

            int difference = a - b;
            Console.WriteLine(difference);

            int product = a * b;
            Console.WriteLine(product);

            int quotient = a / b;
            Console.WriteLine(quotient);

            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1984, 11, 26);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);
            Console.WriteLine( timeSpan.Days ); 

        }
    }
}
