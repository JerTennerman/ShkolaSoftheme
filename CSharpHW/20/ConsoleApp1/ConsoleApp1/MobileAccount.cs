﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class MobileAccount:IMobileAccount
    {
        public ulong Number { get; set; }
        public string Name { get;}
        public Operator Op { get; set; }
        private string _surname;
        private int _yearOfBirth;
        private string _email;


        public delegate void EventHandler(object sender, MobileAccountEventArgs e);
        public event EventHandler OnCall;
        public event EventHandler OnSms;

        public Dictionary<int, MobileAccount> phonebook;

        public MobileAccount(string newName, string surname, int yearOfBirth, string email)
        {
            var validationAccount=new ValidationAccount(newName, surname, yearOfBirth, email);
            if (validationAccount.IsValidated)
            {
                phonebook = new Dictionary<int, MobileAccount>();
                Name = newName;
                _surname = surname;
                _yearOfBirth = yearOfBirth;
                _email = email;
            }
        }

        public void AddToContacts(MobileAccount newContact)
        {
            phonebook.Add(phonebook.Count+1,newContact);
        }

        public void Call(ulong acceptor)
        {
            if (CheckOperator())
            {
                Console.WriteLine("Called {0} from {1}", acceptor, Number);
                OnCall?.Invoke(this, new MobileAccountEventArgs(acceptor));
            }
        }

        public void Sms(ulong acceptor, string message)
        {
            if (CheckOperator())
            {
                Console.WriteLine("Sent \"{0}\" from {1} to {2}", message, Number, acceptor);
                OnSms?.Invoke(this, new MobileAccountEventArgs(acceptor, message));
            }
        }

        public void Call(object acceptor)
        {
            if (!CheckOperator()) return;
            var phoneBookContact = acceptor as MobileAccount;
            foreach (var contact in phonebook)
            {
                if (contact.Value == phoneBookContact)
                {
                    Console.WriteLine("Called {0} from {1}", phoneBookContact.Name, Number);
                    OnCall?.Invoke(this, new MobileAccountEventArgs(phoneBookContact.Number));
                    return;
                }
            }
            Console.WriteLine("contact is not in phone book");
        }

        public void Sms(object acceptor, string message)
        {
            if (!CheckOperator()) return;
            var phoneBookContact = acceptor as MobileAccount;
            foreach (var contact in phonebook)
            {
                if (contact.Value == phoneBookContact)
                {
                    Console.WriteLine("Sent {0} from {1} to {2}", message, Number, phoneBookContact.Name);
                    OnSms?.Invoke(this, new MobileAccountEventArgs(phoneBookContact.Number, message));
                    return;
                }
            }
            Console.WriteLine("contact {0} is not in phone book", phoneBookContact.Number);
        }

        public void BeingAcceptor(MobileAccount sender, string type)
        {
            var myContact = from contact in phonebook
                            where contact.Value.Number == sender.Number
                            select contact;
            if(myContact!= null)
            {
                Console.Write(sender.Name);
            }
            else
            {
                Console.Write(sender.Number);
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
            if(Op==null)
            {
                Console.WriteLine("Can't be done without operator");
                return false;
            }
            return true;
        }
    }
}
