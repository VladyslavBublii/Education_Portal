using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Bubliu_.Bl.Session
{
    public class IsValideSession
    {
        string Email;
        string Password;
        public IsValideSession(string Email,string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
        public bool StartSession()
        {
            if (true) { return true; }
            else { return false; }
        }

    }
}
