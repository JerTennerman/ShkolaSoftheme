﻿using System;
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
            Console.WriteLine("User {0}: password - {1}, email - {2}, last online - {4}",name,password,email,lastOnline);
        }
        public string name { get; private set; }
        public string password { get; private set; }
        public string email { get; private set; }
        public DateTime lastOnline { get; set; }
    }
}
