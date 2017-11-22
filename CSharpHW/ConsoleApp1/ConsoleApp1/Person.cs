using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person :Human
    {
        public override void Move()
        {
            Console.Write("goin");
        }

        public override void Do()
        {
            Console.WriteLine("doing thing");
        }
        public override void Think ()
        {
            Console.WriteLine("thinking smth");
        }
    }
}
