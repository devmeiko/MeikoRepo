using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Admin
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, grade, fieldOfStudy, classNR;
            Console.WriteLine("Please provide the following details:");
            Console.Write("First name: ");
            fName = Console.ReadLine();
            Console.Write("Last name: ");
            lName = Console.ReadLine();
            Console.Write("Grade in highschool: ");
            grade = Console.ReadLine();
            Console.Write("Field of Study: ");
            fieldOfStudy = Console.ReadLine();
            Console.Write("Classnumber: ");
            classNR = Console.ReadLine();

            Console.WriteLine(lName.ToUpper() + ", " + fName);
            Console.WriteLine(grade + fieldOfStudy + classNR);
            Console.WriteLine(fName.ToLower() + "." + lName.ToLower().Replace(" ", "") + "@student.romerocollege.be");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
