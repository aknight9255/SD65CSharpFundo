using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public class Customer : Person
    {
        public bool IsPremium { get; set; }
        public bool SubscribedToEmails { get; set; }
    }
}
