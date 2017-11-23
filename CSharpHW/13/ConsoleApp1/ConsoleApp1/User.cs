using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User : IUser
    {
       public User(string login, string pass)
        {
            if(!login.Contains('@'))
            {
                name = login;
            }
            else
            {
                email=login;
            }
            password = pass;
            lastOnline = DateTime.Now;
        }
        public void GetFullInfo()
        {
            if(name==null)
            {
                Console.Write("\nUser {0}: password - {1}", email, password);
            }
            else
            {
                Console.Write("\nUser {0}: password - {1}", name, password);
            }
            Console.Write(", last online -"+lastOnline);
        }
        public string name { get; private set; }
        public string password { get; private set; }
        public string email { get; private set; }
        public DateTime lastOnline { get; set; }
    }
}
