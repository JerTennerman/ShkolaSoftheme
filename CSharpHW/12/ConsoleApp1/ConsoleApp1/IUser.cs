using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IUser
    {
        string name { get;}
        string email { get;}
        string password { get;}
        DateTime lastOnline { get; set; }
        void GetFullInfo();
    }
}
