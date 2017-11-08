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
        }
    }
    class Point
    {
        public int _x;
        public int _y;

        public Point(int x=0, int y=0)
        {
            _x = x;
            _y = y;
        }
    }
    class ShapeDescriptor
    {
        string basicShape;
        public ShapeDescriptor(Point a)
        {
            basicShape = "point";
        }
        public ShapeDescriptor(Point a, Point b)
        {
            basicShape = "line";
        }
        public ShapeDescriptor(Point a, Point b, Point c)
        {
            basicShape = "triangle";
        }
        public ShapeDescriptor(Point a, Point b, Point c, Point d)
        {
            basicShape = "quadrangle";
        }
        public string ShapeType(Point a, Point b, Point c)
        {
            var ab = Math.Sqrt(Math.Pow(b._x - a._x, 2) + Math.Pow(b._y - a._y, 2));
            var ac = Math.Sqrt(Math.Pow(c._x - a._x, 2) + Math.Pow(c._y - a._y, 2));
            var bc = Math.Sqrt(Math.Pow(c._x - b._x, 2) + Math.Pow(c._y - b._y, 2));
            double max;
            double s1, s2;
            if (ab > ac && ab > bc)
            {
                max = ab;
                s1 = ac;
                s2 = bc;
            } else if (bc > ac)
            {
                max = bc;
                s1 = ac;
                s2 = ab;
            } else
            {
                max = ac;
                s1 = ab;
                s2 = bc;
            }
            if ((ab > ac + bc) || (ac > ab + bc) || (bc > ac + ab))
            {
                return "Triangle doesn't exist";
            }
            else if (ab == ac && ab == bc)
            {
                return "Equilateral triangle";
            }
            else if ((ab == ac) || (ab == bc) || (ac == bc))
            {
                return "Isosceles triangle";
            }
            else if (max * max == s1 * s1 + s2 * s2)
            {
                return "Right Triangle";
            }
            else 
            {
                return "Scalene Triangle";
            }
        }
        public string ShapeType(Point a, Point b, Point c, Point d)
        {
            var ab = Math.Sqrt(Math.Pow(b._x - a._x, 2) + Math.Pow(b._y - a._y, 2));
            var ac = Math.Sqrt(Math.Pow(c._x - a._x, 2) + Math.Pow(c._y - a._y, 2));
            var db = Math.Sqrt(Math.Pow(d._x - b._x, 2) + Math.Pow(d._y - b._y, 2));
            var dc = Math.Sqrt(Math.Pow(d._x - c._x, 2) + Math.Pow(d._y - c._y, 2));

        }
    }
}
