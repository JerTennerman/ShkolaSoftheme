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
        public static void Print(Printer printer, string[] str, string[] colArr)
        {
            foreach (string msg in str)
            {
                foreach (string colour in colArr)
                {
                    ConsoleColor col;
                    if (Enum.TryParse(colour, out col))
                    {
                        Console.ForegroundColor = col;
                        Console.Write(msg);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(colour+" is not a colour, or is not supported");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
