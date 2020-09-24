using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactor
{
    public class RealConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
