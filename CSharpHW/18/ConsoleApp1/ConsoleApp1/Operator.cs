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

        private Dictionary<ulong, MobileAccount> _accounts;

        public Operator(string name)
        {
            Name = name;
            _accounts = new Dictionary<ulong, MobileAccount>();
        }

        public void Add(MobileAccount acc)
        {
            try
            {
                _accounts.Add(acc.number, acc);
                acc.OnCall += (sender, args) => { Connect(sender, args); };
                acc.OnSms += (sender, args) => { RedirectSms(sender, args); };
                acc.op = this;
                acc.isGotOperator = true;
            }
            catch (Exception keyException)
            {
                Console.WriteLine(keyException);
            }

        }

        private void Connect(object sender, MobileAccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var acc = sender as MobileAccount;
            Console.WriteLine("connected {0} and {1}", acc.number, e.Acceptor);
            Console.ResetColor();
        }

        private void RedirectSms(object sender, MobileAccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var acc = sender as MobileAccount;
            Console.WriteLine("redirected message: \"{0}\" from {1} to {2}",e.Message, acc.number, e.Acceptor);
            Console.ResetColor();
        }
    }
}
