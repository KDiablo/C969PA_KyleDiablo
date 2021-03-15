using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C969PA_KyleDiablo
{
    class UserSession
    {
        private string _username;
        private string _password;
        private DateTime _loginTime;
        private CultureInfo _userLocale;

        public UserSession(string username, string password)
        {
            _username = username;
            _password = password;
            _loginTime = DateTime.Now;
            _userLocale = CultureInfo.InstalledUICulture;
        }

        public CultureInfo uci
        {
            get { return _userLocale; }
        }

        public bool ValidateInput()
        {
            if( String.IsNullOrWhiteSpace(_username) || String.IsNullOrWhiteSpace(_password) )
            { return false; }
            else 
            { return true; }
        }

        public bool VerifyInput()
        {
            return true;
        }
    }
}
