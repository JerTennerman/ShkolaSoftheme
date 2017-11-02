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
            int dd = ReadDate();
            if (dd > 0 && dd <= 31)
            {
                int mm = ReadMonth();
                if(mm>0 && mm<13)
                {
                    int yyyy = ReadYear();
                    if(DayMonth(dd,mm,yyyy))
                    ZodiacSign(dd,mm);
                }
                else
                {
                    Console.WriteLine("ivalid month");
                }
            }
            else
            {
                Console.WriteLine("invalid day");
            }
            Console.ReadKey();
        }

        static int ReadDate()
        {
            Console.WriteLine("Enter day");
            Int32.TryParse(Console.ReadLine(), out int d);
            return d;
        }

        static int ReadMonth()
        {
        Console.WriteLine("Enter month");
        Int32.TryParse(Console.ReadLine(), out int m);
        return m;
        }

        static int ReadYear()
        {
            Console.WriteLine("Enter year");
            Int32.TryParse(Console.ReadLine(), out int y);
            return y;
        }

        static bool DayMonth(int d,int m,int y)
        {
            bool legit=true;
            if(m==1 || m==3 || m==5 || m==7 || m==8 || m==10 || m==12)
            {
                if (d>31)
                {
                    legit = false;
                }
            }
            else
            {
                if(m==2)
                {
                    if (LeapYear(y))
                    {
                        if(d>29)
                        {
                            legit = false;
                        }
                    }
                }
                else
                {
                    if(d>30)
                    {
                        legit = false;
                    }
                }
            }
            return legit;
        }

        static bool LeapYear(int y)
        {
            bool leap=true;
            if (y>0 && y % 4 == 0)
            {
                if(y%100==0 && y%400!=0)
                {
                    leap = false;
                }
            }
            else
            {
                leap = false;
            }
            return leap;
        }

        static void ZodiacSign(int d, int m)
        {
            switch (m)
            {
                case 1:
                    if (d<=20)
                    {
                        Console.WriteLine("The Mountain Sea - goat");
                    }
                    else
                    {
                        Console.WriteLine("The Water-bearer");
                    }
                    break;
                case 2:
                    if (d <= 19)
                    {
                        Console.WriteLine("The Water-bearer");
                    }
                    else
                    {
                        Console.WriteLine("The fish");
                    }
                    break;
                case 3:
                    if (d <= 20)
                    {
                        Console.WriteLine("The Fish");
                    }
                    else
                    {
                        Console.WriteLine("The Ram");
                    }
                    break;
                case 4:
                    if (d <= 20)
                    {
                        Console.WriteLine("The Ram");
                    }
                    else
                    {
                        Console.WriteLine("The Bull");
                    }
                    break;
                case 5:
                    if (d <= 21)
                    {
                        Console.WriteLine("The Bull");
                    }
                    else
                    {
                        Console.WriteLine("The Twins");
                    }
                    break;
                case 6:
                    if (d <= 21)
                    {
                        Console.WriteLine("The Twins");
                    }
                    else
                    {
                        Console.WriteLine("The Crab");
                    }
                    break;
                case 7:
                    if (d <= 22)
                    {
                        Console.WriteLine("The Crab");
                    }
                    else
                    {
                        Console.WriteLine("The Lion");
                    }
                    break;
                case 8:
                    if (d <= 21)
                    {
                        Console.WriteLine("The Lion");
                    }
                    else
                    {
                        Console.WriteLine("The Maiden");
                    }
                    break;
                case 9:
                    if (d <= 23)
                    {
                        Console.WriteLine("The Maiden");
                    }
                    else
                    {
                        Console.WriteLine("The Scales");
                    }
                    break;
                case 10:
                    if (d <= 23)
                    {
                        Console.WriteLine("The Scales");
                    }
                    else
                    {
                        Console.WriteLine("The Scorpion");
                    }
                    break;
                case 11:
                    if (d <= 22)
                    {
                        Console.WriteLine("The Scorpion");
                    }
                    else
                    {
                        Console.WriteLine("The Archer");
                    }
                    break;
                case 12:
                    if (d <= 22)
                    {
                        Console.WriteLine("The Archer");
                    }
                    else
                    {
                        Console.WriteLine("The Mountain Sea-goat");
                    }
                    break;
                default: break;

            }
        }
    }
}
