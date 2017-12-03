using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MobileAccountEventArgs
    {
        public string Message { get; set; }

        public ulong Acceptor { get; set; }

        public MobileAccountEventArgs(ulong acceptor, string message)
        {
            Message = message;
            Acceptor = acceptor;
        }

        public MobileAccountEventArgs(ulong acceptor)
        {
            Acceptor = acceptor;
        }
    }
}
