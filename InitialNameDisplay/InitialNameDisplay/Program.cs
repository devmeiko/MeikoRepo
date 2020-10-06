using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InitialNameDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, display, fNameUpper ;
            Console.Write("Please enter your first name: ");
            fName = Console.ReadLine();
            fNameUpper = fName.Substring(0, 1);
            Console.Write("Please enter your last name: ");
            lName = Console.ReadLine();

            display = fNameUpper.ToUpper() + ". " + lName.ToUpper();
            Console.WriteLine(display);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
