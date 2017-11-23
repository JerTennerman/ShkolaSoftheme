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
            var winningTicket = new Lottery();
            Console.WriteLine("Enter your 6 digit lottery ticket, with characters from 1 to 9:");
            var ticket = new Ticket();
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i+1 + ": ");
                if (Int32.TryParse(Console.ReadLine(), out int num) && num > 0 && num < 10)
                {
                    ticket[i] = num;
                }
                else
                {
                    Console.WriteLine("invalid number");
                    i--;
                }
            }
            var win = true;
            Console.WriteLine("Guess|Lottery");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\n" + ticket[i] + "    |" + winningTicket[i]);
                if (ticket[i] != winningTicket[i])
                {
                    win = false;
                }
                else
                {
                    Console.Write("  +");
                }
            }
            if(win)
            {
                Console.WriteLine("\nYou've won");
            }
            else
            {
                Console.WriteLine("\nYou've lost");
            }
        }
    }
}
