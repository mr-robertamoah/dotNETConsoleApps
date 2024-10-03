using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UsingWhile
    {
        public static void Run()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the UsingWhile program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine("Provide Two numbers and keep guessing the right product of the numbers");

            Console.Write("What is the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int correctAnswer = firstNumber * secondNumber;

            Console.WriteLine("What is " + firstNumber + " X " + secondNumber + "?");
            Console.WriteLine();

            Console.Write("Provide your answer: ");
            int providedAnswer = Convert.ToInt32(Console.ReadLine());

            while (correctAnswer != providedAnswer)
            {
                Console.WriteLine("Sorry! You will have to try again");
                Console.WriteLine();

                Console.Write("Provide your answer. ");
                providedAnswer = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Well done.");

            Console.ReadLine();
        }
    }
}
