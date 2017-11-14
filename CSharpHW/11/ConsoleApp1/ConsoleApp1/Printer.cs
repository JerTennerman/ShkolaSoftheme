using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Printer
    {
        public virtual void Print(string str)
        {
            Console.WriteLine(str);
        }
        public virtual void Print(string str, string colour)
        {
            Console.WriteLine(str);
        }
    }
}
