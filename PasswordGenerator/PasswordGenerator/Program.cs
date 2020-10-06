using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, lNameUpper ,phoneNumber, display, displayLName;
            float zipCode;
            Console.Write("Please enter your first name: ");
            fName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            lName = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Please enter your ZIP code: ");
            zipCode = float.Parse(Console.ReadLine());
            lNameUpper = lName.ToUpper();

            displayLName = lNameUpper.Substring(0, 1) + lName.Substring(1, 1);
            display = displayLName + displayLName.Substring(1, 0) + phoneNumber.Substring(1, 2) + Math.Pow(zipCode,2);
            Console.WriteLine(display);

            Console.ReadLine();
        }
    }
}
