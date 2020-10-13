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
            float euro, usdConverter;
            char eurSign;

            //Intro
            Console.WriteLine("Wisselkoers van EURO naar USD");
            Console.Write("Voer het het aantal in:");

            //Calculating
            euro = float.Parse(Console.ReadLine()); //float.Parse for string to float
            usdConverter = (float)Math.Round((euro * 1.1754),2); //(float) for double to float

           // USD = decimal.Round((decimal)(USDConvert),2); // Convert.ToDecimal for float to decimal 

            eurSign = '\u20AC';

            //Result
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(eurSign + "" + euro + " = $" + usdConverter);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press enter to exit...");
            Console.ResetColor();//fckvrythng
            Console.WriteLine("aAAAAAAAAAaaa help");
            Console.ReadLine();
        }
    }
}
