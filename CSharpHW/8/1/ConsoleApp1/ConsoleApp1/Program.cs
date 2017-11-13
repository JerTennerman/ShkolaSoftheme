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
            User user1 = new User("qwerty", 15, "zxcv", 'F');
            User user2 = new User();
            user1.GetInfo();
            user2.GetInfo();
            user2.Clone(user1);
            user1.GetInfo();
            user2.GetInfo();
        }
    }

}
