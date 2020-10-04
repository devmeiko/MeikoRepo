using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateY
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            Console.Write("Give value a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Give value b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Give value c: ");
            c = int.Parse(Console.ReadLine());
            sum = a * b / c;
            Console.WriteLine("Value y = " + sum);
            Console.ReadLine();

        }
    }
}
