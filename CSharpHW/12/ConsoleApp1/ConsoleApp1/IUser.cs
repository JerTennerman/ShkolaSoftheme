using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IUser
    {
        string name(string n);
        string email(string mail);
        string passwod(string pass);
        string GetFullInfo();
    }
}
