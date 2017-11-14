using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Printer();
            p1.Print("str");
            p1 = new ColourPrinter();
            p1.Print("str", "Green");
        }
    }
}
