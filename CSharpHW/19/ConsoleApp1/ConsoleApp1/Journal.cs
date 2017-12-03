using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Journal
    {
        public MobileAccount Sender;

        public ulong Acceptor;

        public string Type;

        public Journal(MobileAccount sender, ulong acceptor, string type)
        {
            Sender = sender;
            Acceptor = acceptor;
            Type = type;
        }

    }
}
