using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction
{
    public class Banana : IFruit
    {
        public string Name { get { return "Banana"; }  }
        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana";
        }

    }

    public class Orange : IFruit
    {
        public string Name { get { return "Orange"; } }

        public bool IsPeeled { get; private set; }
        public Orange(){}
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Peel()
        {
            IsPeeled = true;
            return "You peel the orange";
        }
        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public string Name { get { return "Grape"; } }
        public bool IsPeeled { get; } = false;
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
}
