using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MobileAccount
    {
        public ulong number;

        public string name;

        public Operator op;

        public delegate void MobileAccountHandler(object sender, MobileAccountEventArgs e);

        public event MobileAccountHandler OnCall;

        public event MobileAccountHandler OnSms;

        public Dictionary<int, MobileAccount> phonebook;

        public MobileAccount(ulong newNumber, string newName)
        {
            number = newNumber;
            name = newName;
            Operator op = new Operator("defOp");
            phonebook = new Dictionary<int, MobileAccount>();
        }

        public void AddToContacts(MobileAccount newContact)
        {
            phonebook.Add(phonebook.Count+1,newContact);
        }

        public void Call(ulong acceptor)
        {
            Console.WriteLine("Called {0} from {1}", acceptor, number);
            OnCall?.Invoke(this, new MobileAccountEventArgs(acceptor));

        }

        public void Sms(ulong acceptor, string message)
        {
            Console.WriteLine("Sent {0} from {1} to {2}", message, number, acceptor);
            OnSms?.Invoke(this, new MobileAccountEventArgs(acceptor, message));
        }

        public void Call(MobileAccount phoneBookContact)
        {
            Console.WriteLine("Called {0} from {1}", phoneBookContact.name, number);
            OnCall?.Invoke(this, new MobileAccountEventArgs(phoneBookContact.number));

        }

        public void Sms(MobileAccount phoneBookContact, string message)
        {
            Console.WriteLine("Sent {0} from {1} to {2}", message, number, phoneBookContact.name);
            OnSms?.Invoke(this, new MobileAccountEventArgs(phoneBookContact.number, message));
        }
    }
}
