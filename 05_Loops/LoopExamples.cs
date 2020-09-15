using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while (true)
            {
                if(total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }

                total++;
            }

            int someCount;
            bool keepLooping = true;
            Random rand = new Random();
            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }

                Console.WriteLine(someCount);
                if(someCount == 15)
                {
                    keepLooping = false;
                }

            }

        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 47;

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Jonathon", "Tomislav", "Gordon", "Adam", "Andrew","Amanda" };
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there {students[i]}!");
            }

        }
        enum TestEnum { banana, twig, helpMe, clergy}
        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Jonathon", "Tomislav", "Gordon", "Adam", "Andrew", "Amanda","Brandon","Jamie" };

            foreach(var eachItem in Enum.GetValues(typeof(TestEnum)))
            {
                Console.WriteLine(eachItem);
            }

            foreach(string student in students)
            {
                Console.WriteLine($"Hello my name is {student}");
            }

            string myName = "Amanda Joy Knight";
            foreach(char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

          
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!!");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("my do while condition is false!");
            }
            while (false);

            while (false)
            {
                Console.WriteLine("My while condition is false");
            }
        }
    }


}
