using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class Operator
    {
        private string _name;
        private ulong _registeredNumbers=380950000000;

        private List<JournalEntry> _operatorsJournal;
        private Dictionary<MobileAccount, double> _topUsers;
        private Dictionary<ulong, double> _topCalled;   
        private Dictionary<ulong, MobileAccount> _accounts;

        public void Initialize(string name)
        {
            _name = name;
            _accounts = new Dictionary<ulong, MobileAccount>();
            _topUsers = new Dictionary<MobileAccount, double>();
            _topCalled = new Dictionary<ulong, double>();
            _operatorsJournal = new List<JournalEntry>();
        }

        public void Add(object newAccount)
        {
            var account = newAccount as MobileAccount;
            var validationAccount = new ValidationAccount(account);
            if(validationAccount.IsValidated)
            {
                account.Number = _registeredNumbers;
                _accounts.Add(account.Number, account);
                account.OnCall += (sender, args) => { Connect(sender, args); };
                account.OnSms += (sender, args) => { RedirectSms(sender, args); };
                account.Op = this;
                _topUsers.Add(account, 0);
                _registeredNumbers++;
            }

        }

        private void Connect(object sender, MobileAccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var account = sender as MobileAccount;

            _topUsers[account]++;
            if(_topCalled.ContainsKey(e.Acceptor))
            {
                _topCalled[e.Acceptor]++;
            }
            else
            {
                _topCalled.Add(e.Acceptor, 0);
            }

            _operatorsJournal.Add(new JournalEntry(account, e.Acceptor, "Call"));
            Console.WriteLine("connected {0} and {1}", account.Number, e.Acceptor);
            Console.ResetColor();

            try
            {
                _accounts[e.Acceptor].BeingAcceptor(account,"Call");
            }
            catch (Exception notRegisteredUserException)
            {
                Console.WriteLine(e.Acceptor + "is other operators client" +notRegisteredUserException.Message);
            }
        }

        private void RedirectSms(object sender, MobileAccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var account = sender as MobileAccount;

            _topUsers[account]+=0.5;
            if (_topCalled.ContainsKey(e.Acceptor))
            {
                _topCalled[e.Acceptor]+=0.5;
            }
            else
            {
                _topCalled.Add(e.Acceptor, 0);
            }

            _operatorsJournal.Add(new JournalEntry(account, e.Acceptor, "SMS"));

            Console.WriteLine("redirected message: \"{0}\" from {1} to {2}",e.Message, account.Number, e.Acceptor);
            Console.ResetColor();
            try
            {
                _accounts[e.Acceptor].BeingAcceptor(account,"sms");
            }
            catch(Exception notRegisteredUserException)
            {
                Console.WriteLine(e.Acceptor + "is other operators client");
            }
        }

        public void ShowJournal()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\noperator's journal looks like this :");
            foreach(var entry in _operatorsJournal)
            {
                Console.Write(entry.Sender.Number);
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
            var mostCalled = _topCalled.OrderBy(x => x.Value).Select(y => y.Key);
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
            var mostActive = _topUsers.OrderBy(x => x.Value).Select(y => y.Key);
            foreach (var number in mostActive)
            {
                Console.WriteLine(number.Name);
                count++;
                if(count==5)
                {
                    return;
                }
            }
        }
    }
}
