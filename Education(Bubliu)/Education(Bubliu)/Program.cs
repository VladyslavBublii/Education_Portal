using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Bubliu_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tHello, welcome to the Education portal");
            Console.WriteLine("");
            Console.WriteLine("");
            Welcomes Welcome = new Welcomes();
            Welcome.Begin();

            Console.ReadLine();
        }
    }

}
