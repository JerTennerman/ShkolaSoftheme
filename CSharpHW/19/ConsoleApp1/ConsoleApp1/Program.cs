using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new Operator("qwerty");
            var users = new List<MobileAccount>();

            FillList(users);
            FillPhoneBook(users);
            GiveOperator(users, op);
            Filler(users);

            op.ShowJournal();
            op.MostActive();
            op.MostCalled();

            Console.ReadKey();
        }

        static void FillList(List<MobileAccount> emptyList)
        {
            emptyList.Add(new MobileAccount(380951234567, "Alex"));
            emptyList.Add(new MobileAccount(380635678902, "Bob"));
            emptyList.Add(new MobileAccount(481724621846, "Nick"));
            emptyList.Add(new MobileAccount(562546254266, "Sam"));
            emptyList.Add(new MobileAccount(436452345233, "Mark"));
            emptyList.Add(new MobileAccount(546546547754, "John"));
            emptyList.Add(new MobileAccount(257547654564, "Mike"));
            emptyList.Add(new MobileAccount(124341235124, "Bill"));
            emptyList.Add(new MobileAccount(435435462462, "Jack"));
            emptyList.Add(new MobileAccount(981464265484, "Andrew"));
        }

        static void FillPhoneBook(List<MobileAccount> users)
        {
            for (int i = 0; i < users.Count - 1; i++)
            {
                for (int j = 0; j < users.Count - 1; j++)
                {
                    users[i].AddToContacts(users[j]);
                }
            }
        }

        static void GiveOperator(List<MobileAccount> users, Operator op)
        {
            foreach(var user in users)
            {
                op.Add(user);
            }
        }

        static void Filler(List<MobileAccount> users)
        {
            int count = 0;
            Random rand = new Random();
            do
            {
                int sender = rand.Next(users.Count-1);
                int acceptor = rand.Next(users.Count-1);
                int type = rand.Next(2);
                if (sender != acceptor)
                {
                    if (type == 1)
                    {
                        users[sender].Call(users[acceptor]);
                    }
                    else
                    {
                        users[sender].Sms(users[acceptor], "spam for spam god");
                    }
                    count++;
                }
            } while (count < 100);
        }
    }
}
