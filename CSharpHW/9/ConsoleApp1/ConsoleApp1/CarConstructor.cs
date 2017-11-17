using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class CarConstructor
    {
        public static void Construct(Car car,Color color, Engine.category eng, Transmission transmission)
        {
            car.colour = color;
            car.engine = eng;
            car.transmission = transmission;
        }
        public static void GetInfo(Car car)
        {
            Console.Write("New car got: Color : "+ car.colour);
        }
        public static void Reconstruct(Car car,Engine engine)
        {
            car.engine = engine;
        }
    }
}
