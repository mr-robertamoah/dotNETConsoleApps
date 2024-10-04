using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OddAndEven
    {
        public static void Run()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the OddAndEven program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine("Description");
            Console.WriteLine("This lets you provide minumun and maximum numbers and the program generates the odd and even numbers within the numbers (with the numbers inclusive).");
            Console.WriteLine();

            int minNumber = 0, maxNumber = 0;

            do
            {
                (_, minNumber) = MainClass.GetIntFromUser(
                    "What is the minimum number for the range of numbers? "
                );
                
                Console.WriteLine();

                (_, maxNumber) = MainClass.GetIntFromUser(
                    "What is the maximum number for the range of numbers? "
                );

                if (maxNumber <= minNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{maxNumber} (maximum) should be greater than {minNumber} (minimum)");
                    Console.WriteLine("You have to repeat the entries.");
                    continue;
                }

                break;
            } while (maxNumber <= minNumber);


            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = minNumber; i <= maxNumber; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                    continue;
                }

                oddNumbers.Add(i);
            }

            PrintFromList(evenNumbers, "These are the even numbers:");
            PrintFromList(oddNumbers, "These are the odd numbers:");

            Console.ReadLine();
        }

        static void PrintFromList( List<int> list, string message )
        {

            Console.WriteLine(message);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}