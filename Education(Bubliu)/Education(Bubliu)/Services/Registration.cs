using System;
using Education_Bubliu_.Bl.DTO;
using Education_Bubliu_.Bl.Servises;
using static Education_Bubliu_.Bl.Servises.ValidPass;

namespace Education_Bubliu_
{
    class Registration
    {


        public void UserRegistration()
        {
            Console.WriteLine("Do you want to register ?(y/n)");
            char choise = Convert.ToChar(Console.ReadLine());

            if (choise == 'y')
            {

                Console.WriteLine("Enter your name");
                string Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Welcome " + Name);

                string Email;

                //email check
                while (true)
                {
                    Console.WriteLine(Name + " now enter your email");
                    Email = Convert.ToString(Console.ReadLine());

                    ValidEmail Сheck = new ValidEmail();
                    if (Сheck.ValideEmail(Email)) { break; } 
                    Console.WriteLine("Invlide email");
                }

                string Password;

                //pass check
                while (true)
                {
                    Console.WriteLine(Name + " now enter your password");
                    Password = Convert.ToString(Console.ReadLine());
                    ValidPass Check = new ValidPass();
                    Strength MediumPass;
                    MediumPass = Strength.Medium;
                    if (Check.PasswordStrength(Password) > MediumPass) { break; }
                    Console.WriteLine("Your pass is not strong");
                }


                Console.WriteLine(Name + " now enter your sex");
                string Sex = Convert.ToString(Console.ReadLine());


                RegisUser UserValide = new RegisUser();
                UserValide.Registration(new InfoUserDTO
                {
                    Name = Name,
                    Email = Email,
                    PassWord = Password,
                    Sex = Sex
                }
                );

            }
            else
            {
                Console.WriteLine("ok, its your choise");
            }
        }
    }
}
