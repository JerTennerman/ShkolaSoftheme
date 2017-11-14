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
            var red = new Color("red");
            var merlin = new Engine(3000, 744);
            var defaultTransmission = new Transmission();
            var car = new CarConstructor();
            car.Construct(red, merlin, defaultTransmission);
            car.GetInfo();
            var engine2 = new Engine(654, 120);
            car.Reconstruct(engine2);
            car.GetInfo();
        }
    }
}
