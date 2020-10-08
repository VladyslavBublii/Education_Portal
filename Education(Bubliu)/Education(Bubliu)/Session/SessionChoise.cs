using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Bubliu_.Services
{
    class SessionChoise
    {
        public void Session(string Email, string Password)
        {
            char choise = ' ';
            while (choise != 'q')
            {
                Console.WriteLine(Email);
                Console.WriteLine("\t choose action");
                Console.WriteLine("");
                Console.WriteLine("\t i - see information about yourself");
                Console.WriteLine("");
                Console.WriteLine("\t a - add course");
                Console.WriteLine("");
                Console.WriteLine("\t q - exit");
                Console.WriteLine("");

                choise = Convert.ToChar(Console.ReadLine());

                switch (choise)
                {
                    case 'i':
                        Console.WriteLine("Your information:");
                        UserInfo Use = new UserInfo(Email, Password);
                        Use.ShowInfo();
                        break;
                    case 'a':
                        Console.WriteLine("Your wont to add course");

                        break;
                    case 'q':
                        Console.WriteLine("Your are exit");
                        break;
                    default:
                        Console.WriteLine("It's not correct");
                        break;
                }
            }
        }
    }
}
