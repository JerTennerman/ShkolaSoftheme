using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker work = new Worker();
            //work.Print();
            work.ShowMessege("qwdqe");
        }
    }

    public class Worker
    {
        public void ShowMessege()
        {
            Console.WriteLine("messege");
        }

        public void ShowMessege(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
