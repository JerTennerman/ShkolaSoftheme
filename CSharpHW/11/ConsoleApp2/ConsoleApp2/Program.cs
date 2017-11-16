using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Printer();
            string[] str = new string[5];
            str[0] = "s0";
            str[1] = "s1";
            str[2] = "s2";
            str[3] = "s3";
            str[4] = "s4";
            ExtensionMethods.Print(p1, str);
            var p2 = new PhotoPrinter();
            ExtensionMethods.Print(p2, str);
            string[] col = new string[5];
            col[0] = "Green";
            col[1] = "Yellow";
            col[2] = "Cyan";
            col[3] = "Red";
            col[4] = "Mayonnaise";
            var p3 = new ColourPrinter();
            ExtensionMethods.Print(p3, str, col);
        }
    }
}
