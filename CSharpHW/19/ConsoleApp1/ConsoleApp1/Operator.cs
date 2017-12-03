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

        private List<Journal> _OperatorsJournal;

        private Dictionary<MobileAccount, double> _TopUsers;

        private Dictionary<ulong, double> _TopCalled;

        private Dictionary<ulong, MobileAccount> _accounts;

        public Operator(string name)
        {
            Name = name;
            _accounts = new Dictionary<ulong, MobileAccount>();
            _TopUsers = new Dictionary<MobileAccount, double>();
            _TopCalled = new Dictionary<ulong, double>();
            _OperatorsJournal = new List<Journal>();
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
                _TopUsers.Add(acc, 0);
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

            _TopUsers[acc]++;

            if(_TopCalled.ContainsKey(e.Acceptor))
            {
                _TopCalled[e.Acceptor]++;
            }
            else
            {
                _TopCalled.Add(e.Acceptor, 0);
            }

            _OperatorsJournal.Add(new Journal(acc, e.Acceptor, "Call"));

            Console.WriteLine("connected {0} and {1}", acc.number, e.Acceptor);

            Console.ResetColor();

            try
            {
                _accounts[e.Acceptor].BeingAcceptor(acc,"Call");
            }
            catch (Exception NotRegisteredUserException)
            {
                Console.WriteLine(e.Acceptor + "is other operators client");
            }
        }

        private void RedirectSms(object sender, MobileAccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            var acc = sender as MobileAccount;

            _TopUsers[acc]+=0.5;

            if (_TopCalled.ContainsKey(e.Acceptor))
            {
                _TopCalled[e.Acceptor]+=0.5;
            }
            else
            {
                _TopCalled.Add(e.Acceptor, 0);
            }

            _OperatorsJournal.Add(new Journal(acc, e.Acceptor, "SMS"));

            Console.WriteLine("redirected message: \"{0}\" from {1} to {2}",e.Message, acc.number, e.Acceptor);

            Console.ResetColor();
            try
            {
                _accounts[e.Acceptor].BeingAcceptor(acc,"sms");
            }
            catch(Exception NotRegisteredUserException)
            {
                Console.WriteLine(e.Acceptor + "is other operators client");
            }
        }

        public void ShowJournal()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\noperator's journal looks like this :");
            foreach(var entry in _OperatorsJournal)
            {
                Console.Write(entry.Sender.number);
                if(entry.Type=="SMS")
                {
                    Console.Write(" sent SMS to ");
                }
                else
                {
                    Console.Write(" called ");
                }
                Console.Write(entry.Acceptor + "\n");
            }
            Console.ResetColor();
        }

        public void MostCalled()
        {
            int count = 0;
            Console.WriteLine("most called numbers are:");
            var mostCalled = _TopCalled.OrderBy(x => x.Value).Select(y => y.Key);
            foreach(var number in mostCalled)
            {
                Console.WriteLine(number);
                count++;
                if (count == 5)
                {
                    return;
                }
            }
        }

        public void MostActive()
        {
            int count = 0;
            Console.WriteLine("most active users are:");
            var mostActive = _TopUsers.OrderBy(x => x.Value).Select(y => y.Key);
            foreach (var number in mostActive)
            {
                Console.WriteLine(number.name);
                count++;
                if(count==5)
                {
                    return;
                }
            }
        }
    }
}
