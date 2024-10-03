using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FizzBuzz
    {
        public static void Run()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the FizzBuzz program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine("This will check numbers from 1 to the number provided against 3 and 5. If the number is divisible by both 3 and 5, FizzBuzz will be printed. Fizz will be printed if number is divisible by 3 and Buzz when divisible by 5.");

            Console.WriteLine();
            (_, int number) = MainClass.GetIntFromUser();

            bool isDivisibleBy3;
            bool isDivisibleBy5;

            for (int i = 1; i <= number; i++)
            {
                isDivisibleBy3 = i % 3 == 0;
                isDivisibleBy5 = i % 5 == 0;

                if (isDivisibleBy3 && isDivisibleBy5)
                    Console.WriteLine("FizzBuzz");
                else if (isDivisibleBy3)
                    Console.WriteLine("Fizz");
                else if (isDivisibleBy5)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
