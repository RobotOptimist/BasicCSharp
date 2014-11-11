using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Type in the sequence of numbers to prevent DOOM");
            string userInput = Console.ReadLine();

            if (userInput == "4 8 15 16 23 42")
            {
                Console.Beep();
                Console.WriteLine("Success! Doom has been averted.");                
            }
            else
            {
                Console.Beep(1000, 1000);
                Console.WriteLine("Failure!");
            }

            Console.ReadLine();
        }
    }
}
