using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("You should probs eat something friend");
                Console.WriteLine("That's rough buddy");
            }

            int hoursSpentStudying = 4;
            if(hoursSpentStudying < 10)
            {
                Console.WriteLine("Are you even trying");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;

            if (choresAreDone)
            {
                Console.WriteLine("Go have fun playing animal crossing");
            }
            else
            {
                Console.WriteLine("You need to finish your chores. Come on now, I know it is not fun");
            }

            string input = "7";
            int totalHours = int.Parse(input);

            if(totalHours >= 8)
            {
                Console.WriteLine("You should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tired today");
                if (totalHours < 3)
                {
                    Console.WriteLine("You should try to get more sleep");
                }
            }
            //ask user how old set to number
            int age = 18;
            if(age > 17)
            {
                Console.WriteLine("You are an adult");
            }
            else 
            {
                if (age > 12)
                {
                    Console.WriteLine("You are a teenage");
                }
                else if (age > 2)
                {
                    Console.WriteLine("You are just a little kid");
                }
                else
                {
                    Console.WriteLine("How are you on the computer??");
                }
            }

            if(age < 65 && age > 18)
            {
                Console.WriteLine("Your age is between 19 and 64");
            }

            if(age < 17 || age > 18)
            {
                Console.WriteLine("18 isnt a real age"); 
            }

        }
    }
}
