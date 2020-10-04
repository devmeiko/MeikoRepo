using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name;
            name = Console.ReadLine();

            if (name != "Maico")
            {

                Console.WriteLine("Welcome user " + name);
                Console.WriteLine("You are not authorised to use this program");

            }
            else
            {
                Console.WriteLine("Please enter your password");
                string password;
                password = Console.ReadLine();


                while (password != "Test123456password")
                {
                    Console.WriteLine("Wrong password");
                    Console.WriteLine("Please enter your password");
                    password = Console.ReadLine();
                }






                Console.WriteLine("You accessed the useless calculator that can only add two values to each other");
                Console.WriteLine("Enter your Y value");
                int YValue = Console.ReadLine();
                Console.WriteLine("Enter your X value");
                int XValue = (Console.ReadLine());

                int sum = XValue + YValue;
                Console.WriteLine("= " + sum);
                Console.Read();



            }
        }
    }
}
