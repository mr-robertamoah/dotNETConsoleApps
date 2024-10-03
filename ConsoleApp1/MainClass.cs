using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("For UsingWhile type 5.");
            Console.WriteLine();
            Console.Write("Type your selection: ");
            Console.WriteLine();

            int selection = Convert.ToInt32(Console.ReadLine());

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
                default:
                    Console.WriteLine("No program for your selection");
                    break;
            }

            double money = 5.34343;

            Console.WriteLine(string.Format("{0:0.00}", money));
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            Console.ReadLine();
        }
    }
}
