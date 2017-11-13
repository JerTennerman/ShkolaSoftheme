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
            Random rand = new Random();
            const int col = 10;
            int[] arr = new int[col];
            Console.WriteLine("unsorted");
            for (int i = 0; i < col; i++)
            {
                arr[i] = rand.Next(10);
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < col - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nsorted");
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
        }
    }
}
