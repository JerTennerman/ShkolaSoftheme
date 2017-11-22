using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Users : IAuthenticator
    {
        public User[] userArr ;
        private int _amount = 4;
        public Users()
        {
            User[] userArr = new User[10];
        }
        public void AddUser(User newUser)
        {
            var pos = CheckAndExtend();
            if (pos != _amount)
            {
                userArr[pos] = newUser;
            }
            else
            {
                var tmp = _amount;
                Array.Resize(ref userArr, _amount*2);
                userArr[tmp] = newUser;
                _amount++;
            }
        }
        private int CheckAndExtend()
        {
            if (userArr[0] == null)
                return 0;
            var mas = _amount;
            for (int i = mas--; i > 0; i--)
            {
                if (i!=_amount)
                {
                    if (userArr[i] == null && userArr[i++] != null)
                    {
                        return i;
                    }
                }
                return i;
            }
            return _amount;
        }
        public bool AuthenticateUser(IUser user)
        {
            for (int i = 0; i < _amount; i++)
            {

                if ((user.name == userArr[i].name || user.email==userArr[i].email) && user.password==userArr[i].password)
                {
                    user.lastOnline = DateTime.Now;
                    return true;
                }
            }
            return false;
        }
    }
}
