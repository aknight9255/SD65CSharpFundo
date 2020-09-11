using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreeterMethodExecution()
        {
            Greeter greeter = new Greeter();
            greeter.SayHello();

            greeter.SayHello("Squidward");
            greeter.SayHello("Geeter");
            greeter.SayHello("Mr. Krabs");
            greeter.SayHello("867-5309");

            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();

            greeter.GetRandomGreeting();

        }
    }
}
