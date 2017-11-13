using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Engine
    {
        public string _category { get; }
        public int _horsePower { get; }
        public float _mass { get; }
        public Engine(int hp, float mass, string category= "Combustion")
        {
            _horsePower = hp;
            _mass = mass;
            _category = category;
        }
        public void GetEngine()
        {
            Console.Write(" category - " + _category + " ;horse power - " + _horsePower + " ;mass - " + _mass + "kg ");
        }
    }
}
