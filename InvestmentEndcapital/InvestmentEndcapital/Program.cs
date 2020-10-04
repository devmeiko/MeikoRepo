using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentEndcapital
{
    class Program
    {
        static void Main(string[] args)
        {
            float StartCapital, EndCapital, years, interest;
            interest = 1.25f;
            Console.Write("Startkapitaal: ");
            StartCapital = float.Parse(Console.ReadLine());
            Console.Write("Amount of expected years: ");
            years = float.Parse(Console.ReadLine());
            EndCapital = StartCapital * (float)Math.Pow(interest,years);
            Console.WriteLine("Your endcapital would be: " + Math.Round(EndCapital, 2) + "EUR");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
