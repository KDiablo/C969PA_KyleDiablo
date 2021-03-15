using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969PA_KyleDiablo
{
    class User
    {
        private int _userId;
        private string _username;
        private string _password;
        private bool _isActive;

        public User(int userId, string username, string password, bool isActive)
        {
            _userId = userId;
            _username = username;
            _password = password;
            _isActive = isActive;
        }
    }
}
