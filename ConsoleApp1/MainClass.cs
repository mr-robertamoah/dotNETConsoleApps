using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which program do you want to run?");
            Console.WriteLine("For IfConditionals type 1.");
            Console.WriteLine("For UsingSwitches type 2.");
            Console.WriteLine("For ForLoops type 3.");
            Console.WriteLine("For UsingWhile type 4.");
            Console.WriteLine("For UsingDoWhile type 5.");
            Console.WriteLine("6 for the FizzBuzz game.");
            Console.WriteLine("7 for the FillAndFind game.");
            Console.WriteLine();
            Console.Write("Type your selection: ");

            (bool conversionSuccess, int selection) = GetIntFromUser(strict: false);

            Console.WriteLine();

            if (!conversionSuccess)
            {
                Console.WriteLine("The program ends now because you didn't enter a valid number.");
                Thread.Sleep(5000);
                Console.WriteLine("Bye bye");
                Thread.Sleep(1000);
                return;
            }

            switch (selection)
            {
                case 1: 
                    IfConditionals.Run();
                    break;
                case 2:
                    UsingSwitches.Run();
                    break;
                case 3:
                    ForLoops.Run();
                    break;
                case 4:
                    UsingWhile.Run();
                    break;
                case 5:
                    UsingDoWhile.Run();
                    break;
                case 6:
                    FizzBuzz.Run();
                    break;
                case 7:
                    FillAndFind.Run();
                    break;
                default:
                    Console.WriteLine("No program for your selection");
                    break;
            }

            //double money = 5.34343;

            //Console.WriteLine(string.Format("{0:0.00}", money));
            //Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            Console.ReadLine();
        }

        public static (bool, int) GetIntFromUser(
            string message = "Provide the number: ", 
            bool strict = true
        ) {
            bool conversionSuccess = false;
            int number = 0;

            while (!conversionSuccess)
            {
                Console.Write(message);
                string numberInput = Console.ReadLine();

                conversionSuccess = int.TryParse(numberInput, out number);

                if (!conversionSuccess && !strict)
                    break;
            }

            return (conversionSuccess, number);
        }
    }
}
