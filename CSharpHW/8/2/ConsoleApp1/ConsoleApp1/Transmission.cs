using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transmission
    {
        public string _type { get; }
        public byte _speed { get; }
        public Transmission(string type="manual", byte speed=6)
        {
            _type = type;
            _speed = speed;
        }
        public void GetTransmisson()
        {
            Console.Write("type - " +_type + " ;gears - " + _speed +"\n");
        }
    }
}
