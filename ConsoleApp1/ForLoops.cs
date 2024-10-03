using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ForLoops
    {
        public static void Run()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the ForLoops program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.Write("What message do you want to repeat: ");
            string message = Console.ReadLine();
            Console.Write("How many times do you want to repeat it: ");
            int times = Convert.ToInt32(Console.ReadLine());

            if (times < 1)
            {
                Console.WriteLine("You can only repeat 1 or more times");

            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(message);
                }
            }

            Console.ReadLine();
        }
    }
}
