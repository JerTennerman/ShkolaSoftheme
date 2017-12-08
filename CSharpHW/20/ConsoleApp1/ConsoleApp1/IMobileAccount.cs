using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IMobileAccount
    {
        void Call(ulong acceptor);
        void Call(object acceptor);

        void Sms(ulong acceptor, string message);
        void Sms(object acceptor, string message);
    }
}
