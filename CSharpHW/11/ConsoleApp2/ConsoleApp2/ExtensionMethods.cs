using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp2
{
    public static class ExtensionMethods
    {
        public static void Print(Printer printer,string[] str)
        {
            foreach (string msg in str)
                printer.Print(msg);
        }
        public static void Print(ColourPrinter printer, string[] str, string[] colArr)
        {
            foreach (string msg in str)
            {
                foreach (string colour in colArr)
                {
                    printer.Print(msg,colour);
                }
                Console.WriteLine();
            }
        }
    }
}
