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
            var userDataBase = Initialize();
            do
            {
                Console.WriteLine("Login using name or email and password.\nOr enter \"Find\", or \"Dispose\"\nuse exit to exit program");
                Console.Write("Login:");
                var login = Console.ReadLine();
                switch (login)
                {
                    case "Find":
                        {
                            Console.Write("Login:");
                            login = Console.ReadLine();
                            userDataBase.FindByName(login);
                            break;
                        }
                    case "Dispose":
                        {
                            userDataBase.Dispose();
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("type \"exit\" again to exit program");
                            Console.Write("Password:");
                            var password = Console.ReadLine();
                            if(password=="exit")
                            {
                                return;
                            }
                            break;

                        }
                    default:
                        {
                            Console.Write("Password:");
                            var password = Console.ReadLine();
                            var thisUser = new User(login, password);
                            var result = userDataBase.AuthenticateUser(thisUser);
                            if (result == "login")
                            {
                                Console.WriteLine("User authenticated, last online -");
                                Console.Write(thisUser.lastOnline.Date);
                            }
                            else if(result=="new")
                            {
                                Console.WriteLine("User was added to data base");
                                userDataBase.AddUser(thisUser);
                            }
                            else
                            {
                                Console.WriteLine("incorrect password");
                            }
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
        static Users Initialize()
        {
            var userArr = new Users();
            var user1 = new User("qwerty", "12345");
            userArr.AddUser(user1);
            var user2 = new User("1@1.2", "1sadasd");
            userArr.AddUser(user2);
            var user3 = new User("2@sadwad.sadasda", "xzczxc5");
            userArr.AddUser(user3);
            var user4 = new User("ausidhbawyd", "asdasfwadw");
            userArr.AddUser(user4);
            return userArr;
        }
    }
}
