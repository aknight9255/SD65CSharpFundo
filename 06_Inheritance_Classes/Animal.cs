using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public enum DietType { Herbivore = 1, Omnivore, Carnivore}
    public abstract class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType TypeOfDiet { get; set; }

        public Animal()
        {
            Console.WriteLine("This is the Animal Contructor.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
