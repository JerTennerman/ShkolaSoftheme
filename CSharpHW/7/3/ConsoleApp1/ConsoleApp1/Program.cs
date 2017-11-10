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
            var a = new Point();
            var b = new Point(10, 10);
            var c = new Point(-10);
            var d = new Point(0, -10);
            var s1 = new ShapeDescriptor(a);
            var s2 = new ShapeDescriptor(a, b);
            var s3 = new ShapeDescriptor(a, b, c);
            var s4 = new ShapeDescriptor(a, c, d);
            var s5 = new ShapeDescriptor(a, b, c, d);
            Console.WriteLine("basic shapes are: s1="+s1.basicShape+" s2="+s2.basicShape+" s3="+s3.basicShape+" s4="+s4.basicShape+" s5="+s5.basicShape);
            s1.ShapeType(s1);
            s2.ShapeType(s2);
            s3.ShapeType(s3);
            s4.ShapeType(s4);
            s5.ShapeType(s5);
            Console.WriteLine("shapes are: s1=" + s1.basicShape + " s2=" + s2.basicShape + " s3=" + s3.basicShape + " s4=" + s4.basicShape + " s5=" + s5.basicShape);
        }
    }
    public  class Point
    {
        public int _x;
        public int _y;

        public Point(int x=0, int y=0)
        {
            _x = x;
            _y = y;
        }
    }
    public class ShapeDescriptor
    {
        public string basicShape;
        public double ab;
        public double ac;
        public double bc;
        public double bd;
        public double cd;
        public ShapeDescriptor(Point a)
        {
            basicShape = "point";
        }
        public ShapeDescriptor(Point a, Point b)
        {
            basicShape = "line";
            var ab = Math.Sqrt(Math.Pow(b._x - a._x, 2) + Math.Pow(b._y - a._y, 2));
        }
        public ShapeDescriptor(Point a, Point b, Point c)
        {
            basicShape = "triangle";
            ab = Math.Sqrt(Math.Pow(b._x - a._x, 2) + Math.Pow(b._y - a._y, 2));
            ac = Math.Sqrt(Math.Pow(c._x - a._x, 2) + Math.Pow(c._y - a._y, 2));
            bc = Math.Sqrt(Math.Pow(c._x - b._x, 2) + Math.Pow(c._y - b._y, 2));
        }
        public ShapeDescriptor(Point a, Point b, Point c, Point d)
        {
            basicShape = "quadrangle";
            ab = Math.Sqrt(Math.Pow(b._x - a._x, 2) + Math.Pow(b._y - a._y, 2));
            ac = Math.Sqrt(Math.Pow(c._x - a._x, 2) + Math.Pow(c._y - a._y, 2));
            bd = Math.Sqrt(Math.Pow(d._x - b._x, 2) + Math.Pow(d._y - b._y, 2));
            cd = Math.Sqrt(Math.Pow(d._x - c._x, 2) + Math.Pow(d._y - c._y, 2));
        }
        public void ShapeType(ShapeDescriptor shape)
        {
            if (basicShape == "triangle")
            {
                double max;
                double s1, s2;
                if (ab > ac && ab > bc)
                {
                    max = ab;
                    s1 = ac;
                    s2 = bc;
                }
                else if (bc > ac)
                {
                    max = bc;
                    s1 = ac;
                    s2 = ab;
                }
                else
                {
                    max = ac;
                    s1 = ab;
                    s2 = bc;
                }
                if ((ab > ac + bc) || (ac > ab + bc) || (bc > ac + ab))
                {
                    basicShape = "Triangle doesn't exist";
                }
                else if (ab == ac && ab == bc)
                {
                    basicShape = "Equilateral triangle";
                }
                else if ((ab == ac) || (ab == bc) || (ac == bc))
                {
                    basicShape = "Isosceles triangle";
                }
                else if (max * max == s1 * s1 + s2 * s2)
                {
                    basicShape = "Right Triangle";
                }
                else
                {
                    basicShape = "Scalene Triangle";
                }
            }
            else if (basicShape == "quadrangle")
            {
                var max = Math.Max(Math.Max(ab, ac), Math.Max(bd, cd));
                if (max > ab + ac + bd || max > ab + ac + cd || max > ab + bd + cd || max > ac + bd + cd)
                {
                    basicShape = "quadrangle doesn't exist";
                }
                else if ((ab == ac || ab == cd || ab == bd) && (ac == ab || ac == cd || ac == bd) && (cd == ac || cd == ab || cd == bd))
                {
                    if (ab == ac && bd == cd && ab == bd)
                    {
                        ac = Math.Sqrt(ab * ab + ac * ac);
                        if (ab / ac == 1)
                        {
                            basicShape = "square";
                        }
                        else
                        {
                            basicShape = "rhombus";
                        }
                    }
                    else
                    {
                        basicShape = "rectangle";
                    }
                }
                else if ((ab == ac) || (ac == cd) || (cd == bd))
                {
                    basicShape= "deltoid";
                }
                else
                {
                    basicShape= "Trapezoid";
                }
            }
        }
    }
}
