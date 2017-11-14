using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CarConstructor
    {
        public Color _color { get; set; }
        public Engine _engine { get; set; }
        public Transmission _transmission { get; set; }
        public void Construct(Color color, Engine engine, Transmission transmission)
        {
            _color = color;
            _engine = engine;
            _transmission = transmission;
        }
        public void GetInfo()
        {
            Console.Write("New car got: Color : ");
            _color.GetColor();
            Console.Write(" Engine : ");
            _engine.GetEngine();
            Console.Write(" Transmission : ");
            _transmission.GetTransmisson();
        }
        public void Reconstruct(Engine engine)
        {
            _engine = engine;
        }
    }
}
