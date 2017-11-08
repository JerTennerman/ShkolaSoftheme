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
            string option;
            do
            {
                Console.WriteLine("Choose option T-Triangle,S-Square,R-Romb,Q-exit");
                option = Console.ReadLine();
<<<<<<< HEAD
                if (option.Equals("q", StringComparison.InvariantCultureIgnoreCase))
                {
                    return;
                }
                if ( option.Equals("t", StringComparison.InvariantCultureIgnoreCase) || option.Equals("s", StringComparison.InvariantCultureIgnoreCase) || option.Equals("r", StringComparison.InvariantCultureIgnoreCase))
=======
                //if (option == "q" || option == "Q")
                //{
                //    return;
                //}
                if(option.Equals("t", StringComparison.InvariantCultureIgnoreCase) || option.Equals("s", StringComparison.InvariantCultureIgnoreCase) || option.Equals("r", StringComparison.InvariantCultureIgnoreCase))
>>>>>>> 0a6c9c9eb450c87a5d0ca94ee999adab0542cbe5
                {
                    Console.WriteLine("Choose length (1-10)");
                    int n;
                        if (Int32.TryParse(Console.ReadLine(), out n) &&( n >= 1 && n <= 10))
                        {
                             if (option.Equals("t", StringComparison.InvariantCultureIgnoreCase))
                             {
                                 buildTriangle(n);
                             }
                             else if (option.Equals("s", StringComparison.InvariantCultureIgnoreCase))
                             {
                                buildSquare(n);
                              }
                             else if (option.Equals("r", StringComparison.InvariantCultureIgnoreCase))
                             {
                                buildRomb(n);
                             }
                        }
                        else
                        {
                            Console.WriteLine("incorrect length");
                        }
                }

            } while (1!=0);
            Console.ReadKey();
        }

        static void buildTriangle(int N)
        {
            var str = "*";
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(str);
                str += "*";
            }
        }
        static void buildSquare(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void buildRomb(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N ; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = N; k > i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
