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
            var car1 = new Car("Mazda", 2003, "blue");
            Console.WriteLine(car1.Color);
            car1.Color = TuningAtelier.TuneCar();
            Console.WriteLine(car1.Color);
        }
    }

    class Car
    {
        public string Model;
        public int Year;
        public string Color;
        public Car(string model, int year, string color)
        {
            Model = model;
            Year = year;
            Color = color;
        }
    }
    public static class TuningAtelier
    {
        public static string TuneCar()
        {
            var change = "red";
            return change;
        }
    }
}
