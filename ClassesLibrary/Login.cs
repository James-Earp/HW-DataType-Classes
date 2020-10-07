using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Login(string Username, string Password)
        {
            Username = _username;
            Password = _password;
        }
        public Login() { }
        public override string ToString()
        {
            return string.Format("The username is :{0} and the password is :{1}.", Username, Password);
        }
    }
}
