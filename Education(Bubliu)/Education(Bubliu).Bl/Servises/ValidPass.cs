using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Education_Bubliu_.Bl.Servises
{
    public class ValidPass
    {
        public enum Strength { Low = 1, Medium, High, VeryHigh, Paranoid };

        public Strength PasswordStrength(string password)
        {
            int score = 0;
            Dictionary<string, int> patterns = new Dictionary<string, int> { { @"\d", 5 }, //включает цифры
                                                                         { @"[a-zA-Z]", 10 }, //буквы
                                                                         { @"[!,@,#,\$,%,\^,&,\*,?,_,~]", 15 } }; //символы
            if (password.Length > 6)
                foreach (var pattern in patterns)
                    score += Regex.Matches(password, pattern.Key).Count * pattern.Value;

            Strength result;
            switch (score / 50)
            {
                case 0: result = Strength.Low; break;
                case 1: result = Strength.Medium; break;
                case 2: result = Strength.High; break;
                case 3: result = Strength.VeryHigh; break;
                default: result = Strength.Paranoid; break;
            }
            return result;
        }
    }
}
