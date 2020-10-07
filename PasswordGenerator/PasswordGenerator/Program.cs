using System;
using System.Linq;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, lNameUpper, phoneNumber, display, displayLName, zipCode;
            Console.Write("Please enter your first name: ");
            fName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            lName = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Please enter your ZIP code: ");
            zipCode = Console.ReadLine();
            lNameUpper = lName.ToUpper();
            zipCode = zipCode.Substring(0, 1);
            short zipCodeNum = short.Parse(zipCode);

            displayLName = lNameUpper.Substring(0, 1) + lName.Substring(1, 1);
            display = displayLName + lName.Substring(1, 1) + lName.Substring(0, 1) + phoneNumber.Substring(1, 2) + Math.Pow(zipCodeNum, 2);
            Console.WriteLine(display);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
