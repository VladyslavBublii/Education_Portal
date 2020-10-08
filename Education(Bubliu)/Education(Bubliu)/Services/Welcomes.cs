using Education_Bubliu_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Education_Bubliu_
{
    class Welcomes
    {
        public void Begin()
        {
            char choise = ' ';
            while (choise != 'q')
            {
                Console.WriteLine("Are you already registered ?(y/n)");
                Console.WriteLine("");
                Console.WriteLine("Push q if your wont exit");
                choise = Convert.ToChar(Console.ReadLine());

                if (choise == 'y')
                {
                    SessionUser user = new SessionUser();
                    user.UserValidation();
                }
                else if (choise == 'n')
                {
                    Registration NewUser = new Registration();
                    NewUser.UserRegistration();
                }
                else if(choise == 'q')
                {
                    Console.WriteLine("Your are exit");
                }
                else
                {
                    Console.WriteLine("Invalid writeline");
                }
            }

        }
    }
}
