using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Color
    {
        public string _mainColor { get; }
        public string _shade { get; }
        public Color(string color)
        {
            _mainColor = color;
        }
        public Color(string color, string shade)
        {
            _mainColor = color;
            _shade = shade;
        }
        public void GetColor()
        {
            Console.Write(_mainColor + " " + _shade);
        }
    }
}
