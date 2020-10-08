using System;
using Education_Bubliu_.Bl.Session;

namespace Education_Bubliu_.Services
{
    public class UserInfo
    {
        string Email, Password;
        public UserInfo(string Email,string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Email);
            Console.WriteLine(Password);
            ShowUser user = new ShowUser(Email,Password);
        }
    }
}
