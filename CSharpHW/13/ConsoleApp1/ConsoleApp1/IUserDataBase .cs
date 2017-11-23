using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IUserDataBase :IDisposable
    {
        void AddUser(User newUser);
        void FindByName(string name);
    }
}
