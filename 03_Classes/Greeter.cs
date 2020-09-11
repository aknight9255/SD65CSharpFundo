using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello there, {name}");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello Stranger");
        }

        Random _rando = new Random();

        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "Howdy", "Sup", "Hola", "Suh dude", "Hi Y'all", "Guten Tag", "Hello There", "Ni Hao", "Yo Bro", "Waddup", "Wasuuuuuup", "Hi", "Holler-holler", "Zdravstvuytye","Greetings and Salutations" };
            int randomNumber = _rando.Next(0, availableGreetings.Length);
            string randoGreeting = availableGreetings.ElementAt(randomNumber);
            Console.WriteLine(randoGreeting);
        }





    }
}
