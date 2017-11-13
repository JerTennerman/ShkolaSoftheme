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
            const int raz = 1001;
            int[] arr = new int[raz+1];
            var single = 9999;
            Random rnd = new Random();
            var pos = rnd.Next(raz+1);
            arr[pos] = single;
            var j = raz - 1;
            var z = 0;
            for (int i = 0; i < j; i++)
            {
                if(i==pos || j==pos)
                {
                    if(i==pos)
                    {
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }
                arr[i] = z;
                arr[j] = z;
                j--;
                z++;
            }
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
            var singlePos = Search(arr, raz);
            if (singlePos != -1)
            {
                Console.WriteLine("position is - " + singlePos);
            }
            else Console.WriteLine("each array membr got a duplicate");
        }
        static int Search(int[] mas, int bound)
        {
            var j = bound-1;
            for (int i = 0; i < j; i++)
            {
                if(mas[i]!= mas[j])
                {
                    if (mas[i++] == mas[j])
                    {
                        return i--;
                    }
                    else return j;
                }
                j--;
            }
            return -1;
        }
    }
}
