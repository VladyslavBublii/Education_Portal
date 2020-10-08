using Education_Bubliu_.Bl.Servises;
using System;
using static Education_Bubliu_.Bl.Servises.ValidPass;
using Education_Bubliu_.Bl.Session;

namespace Education_Bubliu_.Services
{
    public class SessionUser
    {
        string Email;
        string Password;

        public void UserValidation()
        {
            char choise = ' ';
            while (choise != 'q')
            {
                while (true)
                {
                    Console.WriteLine("Please, enter your email");
                    Email = Convert.ToString(Console.ReadLine());

                    ValidEmail Сheck = new ValidEmail();
                    if (Сheck.ValideEmail(Email)) { break; }
                    Console.WriteLine("This email could not be used for registration");
                    Console.WriteLine("");
                }

                Console.WriteLine("");

                while (true)
                {
                    Console.WriteLine("Now enter your password");
                    Password = Convert.ToString(Console.ReadLine());
                    ValidPass Check = new ValidPass();
                    Strength MediumPass;
                    MediumPass = Strength.Medium;
                    if (Check.PasswordStrength(Password) > MediumPass) { break; }
                    Console.WriteLine("This pass could not be used for registration");
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.WriteLine("Thanks, we search information");

                IsValideSession session = new IsValideSession(Email, Password);

                //проверка данных
                if (session.StartSession())
                {
                    SessionChoise UserSession = new SessionChoise();
                    UserSession.Session(Email, Password);
                }
                else
                {
                    Console.WriteLine("Uncorrect pass or Email");
                    Console.WriteLine("");
                    Console.WriteLine("If your wont exit - write q");
                    choise = Convert.ToChar(Console.ReadLine());
                }
                Console.WriteLine("");

            }

        }

    }
}
