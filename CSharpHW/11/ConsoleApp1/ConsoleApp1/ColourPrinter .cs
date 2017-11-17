using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ColourPrinter :Printer
    {
        public override void Print(string str, string colour="White")
        {
            ConsoleColor col;
            if (Enum.TryParse(colour, out col))
            {
                Console.ForegroundColor = col;
                base.Print(str);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("invalid colour");
            }
        }
    }
}
