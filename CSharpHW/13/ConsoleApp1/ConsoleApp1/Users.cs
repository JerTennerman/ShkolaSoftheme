using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Users : IAuthenticator, IUserDataBase
    {
        private List<User> _userArr;
        public Users()
        {
            _userArr = new List<User>();
        }
        public void AddUser(User newUser)
        {
            _userArr.Add(newUser);
        }

        public string AuthenticateUser(IUser user)
        {
            for (int i = 0; i < _userArr.Count; i++)
            {

                if ((user.name == _userArr[i].name && user.name!=null) || (user.email!=null && user.email==_userArr[i].email))
                {
                    if (user.password == _userArr[i].password)
                    {
                        user.lastOnline = DateTime.Now;
                        return "login";
                    }
                    else
                    {
                        return "fail";
                    }
                }
            }
            return "new";
        }

        public void Dispose()
        {
            foreach(User user in _userArr)
            {
                user.GetFullInfo();
            }
        }

        public void FindByName(string name)
        {
            foreach (User user in _userArr)
            {
                if(user.name==name)
                {
                    Console.WriteLine("password={0}, Last online ={1}",user.password,user.lastOnline.Date);
                }
            }
        }
    }
}
