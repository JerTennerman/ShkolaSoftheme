using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lottery
    {
        readonly int[] numbers;
        public Lottery()
        {
            numbers = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                numbers[i] = rnd.Next(1, 9);
            }
        }
        public int this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }
    }
}
