using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MobileAccount
    {
        private ulong _number;
        private string _name;
        public Operator op;
        public event EventHandler OnCall;
        public event EventHandler OnConnect;
        public MobileAccount(ulong number, string name)
        {
            _number = number;
            _name = name;
            Operator op = new Operator("defOp");
        }
        public void Call(ulong number, string message)
        {
            Console.WriteLine("Called {0} from {1} and said:{2}", number, _number, message);
            OnCall?.Invoke(this, null);
        }
        public void Sms(ulong number, string message)
        {
            Console.WriteLine("Sent {0} from {1} to {2}", message, _number, number);
        }
    }
}
