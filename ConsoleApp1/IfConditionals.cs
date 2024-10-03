using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IfConditionals
    {
        public static void Run()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the IfConditionals program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.Write("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int answer = firstNum * secondNum;
            Console.Write("What is the multiplication of the numbers: ");
            int providedAnswer = Convert.ToInt32(Console.ReadLine());

            if (answer == providedAnswer)
            {
                Console.WriteLine("Well done.");
            }
            else
            {
                Console.WriteLine("You are close.");
            }

            Console.ReadLine();
        }
    }
}
