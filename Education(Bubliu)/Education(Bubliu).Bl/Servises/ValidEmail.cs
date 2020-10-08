using System;
using System.Text.RegularExpressions;
using Education_Bubliu_.Bl.DTO;


namespace Education_Bubliu_.Bl.Servises
{
    public class ValidEmail
    {
        public bool ValideEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

    }
}
