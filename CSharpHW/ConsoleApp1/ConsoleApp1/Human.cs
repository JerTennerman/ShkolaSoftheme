using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public abstract class Human :IHuman
    {
        public int age { get; set; }
        public string Name { get; set; }
        public virtual void Move()
        {
            Console.Write("go");
        }

        public virtual void Do()
        {
            Console.WriteLine("doing");
        }
        public virtual void Think()
        {
            Console.WriteLine("thinking");
        }
    }
}
