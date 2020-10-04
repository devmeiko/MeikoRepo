using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripBoekenWinkel
{
    class Program
    {
        static void Main(string[] args)
        {
            float ComicBook = 5;
            string name;
            float VATPercentage = 21;
            
            Console.Write("Please provide your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "!");
            Console.Write("Please enter the amount of comic books: ");
            float Amount;
            Amount = float.Parse(Console.ReadLine());
            float PriceVatExcl = (float)(Amount * ComicBook);
            float Vat = (float)Math.Round(((PriceVatExcl/100)*106),2);
            Console.WriteLine("Price per book exclusive VAT: " + ComicBook + "EUR");
            Console.WriteLine("Amount of books: " + Amount);
            Console.WriteLine("Subtotal exclusive VAT " + PriceVatExcl + "EUR");
            Console.WriteLine();
            float VATamount = (float)(Vat - PriceVatExcl);
            Console.WriteLine("VAT-amount " + VATPercentage + "%");
            Console.WriteLine("VAT Subtotal " + VATamount + "EUR");
            Console.WriteLine();
            Console.WriteLine("Subtotal including VAT " + Vat + "EUR");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }//RIP
    }
}
