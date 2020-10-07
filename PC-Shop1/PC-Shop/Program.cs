using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            float monitor, keyboard, computer, mouse, phone, data, amount, sub;
            string input;
            monitor = (float)169.5;
            keyboard = (float)55.9;
            computer = (float)1395;
            mouse = (float)30.95;
            phone = (float)650;
            Console.WriteLine("You can choose one of the following products: Monitor, Keyboard, Mouse, Computer, Phone.");
            input = Console.ReadLine();
            
            if(input == "Monitor")
            {
                data = monitor;
                Console.WriteLine("Product: " + input);
                Console.Write("Amount of " + input + "'s: ");
                amount = float.Parse(Console.ReadLine());
                sub = data * amount;
                Console.WriteLine("Price of 1 unit: " + data);

                Console.WriteLine(amount + " pieces of " + input.ToUpper());
                Console.WriteLine("Substotal: " + sub + "EUR");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Press enter to exit...");
                Console.ReadLine();
            }
            else if(input == "Keyboard")
            {
                data = keyboard;
                Console.WriteLine("Product: " + input);
                Console.Write("Amount of " + input + "'s: ");
                amount = float.Parse(Console.ReadLine());
                sub = data * amount;
                Console.WriteLine("Price of 1 unit: " + data);

                Console.WriteLine(amount + " pieces of " + input.ToUpper());
                Console.WriteLine("Substotal: " + sub + "EUR");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Press enter to exit...");
                Console.ReadLine();
            }
            else if(input == "Mouse")
            {
                data = mouse;
                Console.WriteLine("Product: " + input);
                Console.Write("Amount of " + input + "'s: ");
                amount = float.Parse(Console.ReadLine());
                sub = data * amount;
                Console.WriteLine("Price of 1 unit: " + data);

                Console.WriteLine(amount + " pieces of " + input.ToUpper());
                Console.WriteLine("Substotal: " + sub + "EUR");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Press enter to exit...");
                Console.ReadLine();
            }
            else if(input == "Computer")
            {
                data = computer;
                Console.WriteLine("Product: " + input);
                Console.Write("Amount of " + input + "'s: ");
                amount = float.Parse(Console.ReadLine());
                sub = data * amount;
                Console.WriteLine("Price of 1 unit: " + data);

                Console.WriteLine(amount + " pieces of " + input.ToUpper());
                Console.WriteLine("Substotal: " + sub + "EUR");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Press enter to exit...");
                Console.ReadLine();
            }
            else if(input == "Phone")
            {
                data = phone;
                Console.WriteLine("Product: " + input);
                Console.Write("Amount of " + input + "'s: ");
                amount = float.Parse(Console.ReadLine());
                sub = data * amount;
                Console.WriteLine("Price of 1 unit: " + data);

                Console.WriteLine(amount + " pieces of " + input.ToUpper());
                Console.WriteLine("Substotal: " + sub + "EUR");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Press enter to exit...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You did not provide a valid product.");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Press enter to exit...");
                Console.ReadLine();
            }


            
        }
    }
}
