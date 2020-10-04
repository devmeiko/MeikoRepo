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
            string FName, LName, Street, HNumber, ZIP, City;
            Console.WriteLine("Please provide the following details:");

            Console.Write("First Name: ");
            FName = Console.ReadLine();

            Console.Write("Last Name: ");
            LName = Console.ReadLine();

            Console.Write("Street: ");
            Street = Console.ReadLine();

            Console.Write("Housenumber: ");
            HNumber = Console.ReadLine();

            Console.Write("ZIP Code: ");
            ZIP = Console.ReadLine();

            Console.Write("City: ");
            City = Console.ReadLine();

            Console.WriteLine(FName+" "+LName);
            Console.WriteLine(Street+" "+HNumber);
            Console.WriteLine(ZIP+", "+City.ToUpper());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press enter to exit...");
            Console.ReadLine();

        }
    }
}
