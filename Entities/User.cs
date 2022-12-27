using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgimedApp.Entities
{
    public class User
    {
        private int _id;
        private string _login;
        private string _password;

        public int Id { get { return _id; } set { _id = value; } }
        public string Login { get { return _login; } set { _login = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public User(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
    }
}
