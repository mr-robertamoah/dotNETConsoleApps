using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FillAndFind
    {
        public static void Run()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the FillAndFind program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine("Description");
            Console.WriteLine("This lets you decide which numbers you want to store in a box. Then you get find the position of a number you choose from the given set when the numbers are arranged in descending order.");
            Console.WriteLine();

            //Dictionary<string, string> friends = new Dictionary<string, string>()
            //{
            //    {"Jammes", "Amoah"},
            //    {"Robert", "Amoah"},
            //};

            (_, int numberOfItems) = MainClass.GetIntFromUser(
                "How many numbers do you want to put into the box? "
            );

            Console.WriteLine();
            Console.WriteLine("Get ready to make entries into the box.");
            Console.WriteLine();

            int[] entries =  new int[numberOfItems];
            int entry;

            for (int i = 0; i < numberOfItems; i++)
            {
                (_, entry) = MainClass.GetIntFromUser(
                    $"Provide entry {i + 1}: "
                );

                entries[i] = entry;
            }

            // sort entries
            Array.Sort(entries);

            // reverse entries
            Array.Reverse(entries);

            (_, int number) = MainClass.GetIntFromUser(
                "Which number's position do you want to find? "
            );

            int position;
            if (entries.Contains(number))
            {
                position = Array.IndexOf(entries, number);
                Console.WriteLine($"{number} can be found at position: {position + 1}.");
            }
            else
            {
                Console.WriteLine($"{number} was not found in the box.");
                Console.WriteLine();
                Console.WriteLine("The following are the entries:");
                foreach (var item in entries)
                {
                    Console.Write($"{item} ");
                }
            }

            Console.ReadLine();
        }
    }
}
