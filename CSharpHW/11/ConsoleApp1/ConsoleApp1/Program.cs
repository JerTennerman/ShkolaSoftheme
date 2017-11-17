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
            var str = "string";
            var p1 = new Printer();
            p1.Print(str);
            p1 = new ColourPrinter();
            p1.Print(str, "Green");
            p1.Print(str);
            p1 = new PhotoPrinter();
            p1.Print(str);
               
        }
    }
}
