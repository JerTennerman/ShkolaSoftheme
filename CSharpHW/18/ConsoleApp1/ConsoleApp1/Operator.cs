using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operator
    {
        public string Name;
        private List<MobileAccount> _accounts;
        public Operator(string name)
        {
            Name = name;
            _accounts = new List<MobileAccount>();
        }
        public void Add(MobileAccount acc)
        {
            _accounts.Add(acc);
        }
        private void Connect(ulong sender, ulong acceptor)
        {
            MobileAccount acc = _accounts;
            Console.WriteLine("connected {0} and {1}", sender, acceptor);
        }

    }
}
