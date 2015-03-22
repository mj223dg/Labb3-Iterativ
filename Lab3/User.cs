using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativgöraom
    {
        class User
        {
            private string _txtPass;
            private string _txtUser;
            
        public string PassWord
        {
            get { return _txtPass; }
            set
            {
            if(value.Length > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            _txtPass = value;
            }
        }

        public string Username
        {
            get { return _txtUser; }
            set
            {
            if(value.Length > 35)
            {
                throw new ArgumentOutOfRangeException();
            }
            _txtUser = value;
            }
        }

        public User(string txtPass, string txtUser)
        {
            PassWord = txtPass;
            Username = txtUser;
        }

        public User()
        {

        }
    }
}
