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
            string str="**********";
            for (var i = 11; i != 1; i--)
            {
                Console.WriteLine(str);
                str=str.Remove(0,1);
            }
        }
    }
}
