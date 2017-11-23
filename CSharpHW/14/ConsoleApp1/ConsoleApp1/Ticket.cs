using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ticket
    {
        int[] numbers;
        public Ticket()
        {
            numbers = new int[6];
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
