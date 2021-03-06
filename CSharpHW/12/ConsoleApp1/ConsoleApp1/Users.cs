﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Users : IAuthenticator
    {
        public List<User> userArr;
        private int _amount = 0;
        public Users()
        {
            userArr = new List<User>();
        }
        public void AddUser(User newUser)
        {
            userArr.Add(newUser);
            _amount++;
        }
        public bool AuthenticateUser(IUser user)
        {
            for (int i = 0; i < _amount; i++)
            {

                if ((user.name == userArr[i].name || user.email==userArr[i].email) && user.password==userArr[i].password)
                {
                    user.lastOnline = DateTime.Now;
                    return true;
                }
            }
            return false;
        }
    }
}
