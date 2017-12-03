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
            var c1 = new MobileAccount(0951234567, "qwerty");
            var c2 = new MobileAccount(0635678902, "zxcvb");
            op.Add(c1);
            op.Add(c2);
            c1.Call(0635678902);
            c1.Sms(0635678902, "asdasd");
            c1.AddToContacts(c2);
            c1.Call(c2);
            c1.Sms(c2, "sdasdasd");
            var c3 = new MobileAccount(0509877678, "asdf");
            op.Add(c3);
            c1.Call(c3);
            var c4 = new MobileAccount(0509877678, "asdf");
            op.Add(c4);
            c4.AddToContacts(c3);
            c4.Call(c3);
        }
    }
}
