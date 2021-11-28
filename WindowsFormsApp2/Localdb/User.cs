using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Localdb
{
    public class User
    {

        string _username;
        string _email;
        string _password;

        public User()
        {
        }

        public User(string username, string email, string password)
        {
            this._username = username;
            this._email = email;
            this._password = password;
        }

        public bool Equals(User user) 
        {
            if (user.username.Equals(username) && user.email.Equals(email)) {
                return true;
            }
            return false;
        }

        public string username 
        {
            get { return _username; }
            set { _username = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
