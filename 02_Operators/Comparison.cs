using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 142;
            string username = "Sandy";
            bool equals = age == 12;
            bool userIsAdam = username == "SpongeBob";

            bool notEqual = age != 1001;
            bool userIsNotPatrick = username != "Patrick";
            bool testBool = false;

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);
            bool listsAreEqual = firstList == secondList;
            bool itemOnList = firstList[0] == secondList[0];
            Console.WriteLine(listsAreEqual);
            Console.WriteLine(itemOnList);

            bool greaterThan = age > 10;
            bool greaterThanOrEqual = age >= 142;
            bool lessThan = age < 9001;
            bool lessThanOrEqual = age <= 142;

            bool orValue = greaterThan || lessThan;
            bool anotherOr = age < 9005 || username == "banana";

            bool andValue = greaterThan && lessThan;
            bool anotherAnd = username == "Sandy" && age >= 42;


        }
    }
}
