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
            var human1 = new Human ("alex", "qwerty", Convert.ToDateTime("1/1/2000"));
            var human2 = new Human("alex", "qwerty", Convert.ToDateTime("1 / 1 / 2000"));
            var human3 = new Human("wqeqwe", "qwerty", DateTime.Today);
            same(human1, human2);
            same(human1, human3);
            same(human2, human3);

        }
        static void same(Human first, Human second)
        {
          if(first.Compare(second))
          {
              Console.WriteLine("{0} has got a duplicate", first.firstName);
          }
          else
          {
              Console.WriteLine("{0} is not same as {1}", first.firstName, second.firstName);
          }
        }
    }
    class Human
    {
        DateTime birthDate;
        public string firstName;
        string lastName;
        readonly byte age;

        public Human(string name, string surname)
        {
            firstName = name;
            lastName = surname;
            age = 0;
            birthDate = DateTime.Today;
        }

        public Human(string name, string surname, DateTime birthtday)
        {
            firstName = name;
            lastName = surname;
            birthDate = birthtday;
            if ((birthDate.Month < DateTime.Today.Month) || (birthDate.Month == DateTime.Today.Month && birthDate.Day <= DateTime.Today.Day))
            {
                age = (byte)(birthDate.Year - DateTime.Today.Year);
            }
            else
            {
                age = (byte)(birthDate.Year - DateTime.Today.Year - 1);
            }
        }

        public bool Compare(Human otherHuman)
        {
            var equal = false;
            if ((birthDate == otherHuman.birthDate) && (firstName == otherHuman.firstName) && (lastName == otherHuman.lastName))
            {
                equal = true;
            }
            return equal;
        }
    }
}
