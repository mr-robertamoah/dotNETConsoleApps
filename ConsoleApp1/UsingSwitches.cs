using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UsingSwitches
    {
        public static void Run ()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the UsingSwitches program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.Write("What is the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
               case 1:
                    Console.WriteLine("Mon");
                    break;
               case 2:
                    Console.WriteLine("Tues");
                    break;
               case 3:
                    Console.WriteLine("Wed");
                    break;
               case 4:
                    Console.WriteLine("Thurs");
                    break;
               case 5:
                    Console.WriteLine("Fri");
                    break;
               case 6:
                    Console.WriteLine("Sat");
                    break;
               case 7:
                    Console.WriteLine("Thurs");
                    break;
               default:
                    Console.WriteLine("Not a valid day.");
                    break;
            }
        }
    }
}
