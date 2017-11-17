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
            var e1 = Engine.category.combustion;
            var t1 = new Transmission();
            var col = new Color();
            var car = new Car();
            CarConstructor.Construct(car, col, e1, t1);
            CarConstructor.GetInfo(car);
        }
    }
}
