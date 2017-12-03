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

        public bool isGotOperator=false;

        public delegate void MobileAccountHandler(object sender, MobileAccountEventArgs e);

        public event MobileAccountHandler OnCall;

        public event MobileAccountHandler OnSms;

        public Dictionary<int, MobileAccount> phonebook;

        public MobileAccount(ulong newNumber, string newName)
        {
            number = newNumber;
            name = newName;
            phonebook = new Dictionary<int, MobileAccount>();
        }

        public void AddToContacts(MobileAccount newContact)
        {
            phonebook.Add(phonebook.Count+1,newContact);
        }

        public void Call(ulong acceptor)
        {
            if (CheckOperator())
            {
                Console.WriteLine("Called {0} from {1}", acceptor, number);
                OnCall?.Invoke(this, new MobileAccountEventArgs(acceptor));
            }
        }

        public void Sms(ulong acceptor, string message)
        {
            if (CheckOperator())
            {
                Console.WriteLine("Sent \"{0}\" from {1} to {2}", message, number, acceptor);
                OnSms?.Invoke(this, new MobileAccountEventArgs(acceptor, message));
            }
        }

        public void Call(MobileAccount phoneBookContact)
        {
            if (CheckOperator())
            {
                bool isFound = false;
                foreach (var contact in phonebook)
                {
                    if (contact.Value == phoneBookContact)
                    {
                        Console.WriteLine("Called {0} from {1}", phoneBookContact.name, number);
                        OnCall?.Invoke(this, new MobileAccountEventArgs(phoneBookContact.number));
                        isFound = true;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine("contact is not in phone book");
                }
            }
        }

        public void Sms(MobileAccount phoneBookContact, string message)
        {
            if (CheckOperator())
            {
                bool isFound = false;
                foreach (var contact in phonebook)
                {
                    if (contact.Value == phoneBookContact)
                    {
                        Console.WriteLine("Sent {0} from {1} to {2}", message, number, phoneBookContact.name);
                        OnSms?.Invoke(this, new MobileAccountEventArgs(phoneBookContact.number, message));
                        isFound = true;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine("contact {0} is not in phone book", phoneBookContact.number);
                }
            }
        }

        public void BeingAcceptor(MobileAccount sender, string type)
        {
            var myContact = from contact in phonebook
                            where contact.Value.number == sender.number
                            select contact;
            if(myContact!= null)
            {
                Console.Write(sender.name);
            }
            else
            {
                Console.Write(sender.number);
            }
            if(type=="sms")
            {
                Console.Write(" sent you sms\n");
            }
            else
            {
                Console.Write(" called you\n");
            }
        }

        public bool CheckOperator()
        {
            if(!isGotOperator)
            {
                Console.WriteLine("Can't be done without operator");
            }
            return isGotOperator;
        }
    }
}
