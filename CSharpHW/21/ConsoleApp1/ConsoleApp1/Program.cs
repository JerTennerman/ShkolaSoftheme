using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new Operator();
            op.Initialize("qwerty");
            var users = new List<MobileAccount>();

            FillList(users);

            Serialization(users);

            FillPhoneBook(users);
            GiveOperator(users, op);
            Filler(users);

            op.ShowJournal();
            op.MostActive();
            op.MostCalled();

            Console.ReadKey();
        }

        static void Serialization(List<MobileAccount> users)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<MobileAccount>));//33ms

            using (var streamWriter = File.OpenWrite("XML.xml"))
            {
                serializer.Serialize(streamWriter, users);
            }

            var ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(List<MobileAccount>));
            {
                using (FileStream fs = new FileStream("json.json", FileMode.OpenOrCreate))//18ms
                {
                    ser.WriteObject(fs, users);
                }
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream("binary.dat", FileMode.OpenOrCreate))//11ms
                {
                    formatter.Serialize(fs, users);
                }

                var q = 0;
            }
        }

        static void FillList(List<MobileAccount> emptyList)
        {
            /* emptyList.Add(new MobileAccount("Alex", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Bob", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Nick", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Sam", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Mark", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("John", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Mike", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Bill", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Jack", "qwe", 2000, "1@1.1"));
             emptyList.Add(new MobileAccount("Andrew", "qwe", 2000, "1@1.1")); */

            for (int i = 0; i < 1000; i++)
            {
                emptyList.Add(new MobileAccount());
            }

        }

        static void FillPhoneBook(List<MobileAccount> users)
        {
            for (int i = 1; i < users.Count - 1; i++)
            {
                for (int j = 0; j < users.Count - 1; j++)
                {
                    users[i].AddToContacts(users[j]);
                }
            }
        }

        static void GiveOperator(List<MobileAccount> users, Operator op)
        {
            foreach (var user in users)
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
                int sender = rand.Next(users.Count - 1);
                int acceptor = rand.Next(users.Count - 1);
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
