using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Run();
        }

        private void Run()
        {
            string userInput = string.Empty;
            Console.WriteLine("***************************** Simple Rational AI *****************************\n");
            PrintHelpMenu();
            while (true)
            {
                Console.Write("\nInput: ");
                userInput = Console.ReadLine();
                AI.HandleInput(userInput.ToLower());
            }
        }

        private void PrintHelpMenu()
        {
            Console.WriteLine("Syntax for talking with the AI:");
            Console.WriteLine("Write \"create [object]\" to create an object.");
            Console.WriteLine("Write \"[object] is [type]\" to define the object as a type.");
            Console.WriteLine("Write \"[object] can [verb]\" to define what the object can do.");
            Console.WriteLine("Write \"all [type] can [verb]\" to define what all objects of the type can do.");
        }
    }
}
