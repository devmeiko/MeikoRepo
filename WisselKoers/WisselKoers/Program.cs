using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisselKoers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            float Euro, USDConvert;
            char EurSign;

            //Intro
            Console.WriteLine("Wisselkoers van EURO naar USD");
            Console.Write("Voer het het aantal in:");

            //Calculating
            Euro = float.Parse(Console.ReadLine()); //float.Parse for string to float
            USDConvert = (float)Math.Round((Euro * 1.1754),2); //(float) for double to float

           // USD = decimal.Round((decimal)(USDConvert),2); // Convert.ToDecimal for float to decimal 

            EurSign = '\u20AC';

            //Result
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(EurSign + "" + Euro + " = $" + USDConvert);
            Console.ReadLine();
        }
    }
}
