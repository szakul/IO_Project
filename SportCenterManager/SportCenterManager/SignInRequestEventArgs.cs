using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class SignInRequestEventArgs
    {
        public string Login { get; }
        public string Password { get; }
       
        public SignInRequestEventArgs(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
