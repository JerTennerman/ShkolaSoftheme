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
            var op = new Operator("qwerty");
            var c1 = new MobileAccount(1, "1");
            var c2 = new MobileAccount(2, "2");
            op.Add(c1);
            op.Add(c2);
            c1.Call()
        }
    }
}
