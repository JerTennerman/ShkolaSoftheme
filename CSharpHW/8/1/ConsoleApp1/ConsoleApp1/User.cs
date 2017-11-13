using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        string _name;
        int _age;
        string _surname;
        char _gender;
        public User(string name = "undefind", int age = 0, string surname = "undefined", char gender = 'M')
        {
            _name = name;
            _age = age;
            _surname = surname;
            _gender = gender;
        }
        public void Clone(User clonedUser)
        {
            _name = clonedUser._name;
            _age = clonedUser._age;
            _surname = clonedUser._surname;
            _gender = clonedUser._gender;
        }
        public void GetInfo()
        {
            try
            {
                Console.WriteLine("current propeties are : name - {0}, surname - {1}, age - {2}, gender - {3}", _name, _surname, _age, _gender);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
