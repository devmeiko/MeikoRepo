using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            //voornaam, familienaam,straat, huisnummer, postcode en gemeente
            string fName, lName, street, hNumber, zipCode, city;
            Console.WriteLine("Please provide the following details:");

            Console.Write("First Name: ");
            fName = Console.ReadLine();

            Console.Write("Last Name: ");
            lName = Console.ReadLine();

            Console.Write("Street: ");
            street = Console.ReadLine();

            Console.Write("Housenumber: ");
            hNumber = Console.ReadLine();

            Console.Write("ZIP Code: ");
            zipCode = Console.ReadLine();

            Console.Write("City: ");
            city = Console.ReadLine();

            Console.WriteLine(fName+" "+lName);
            Console.WriteLine(street+" "+hNumber);
            Console.WriteLine(zipCode+", "+city.ToUpper());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press enter to exit...");
            Console.ReadLine();

        }
    }
}
