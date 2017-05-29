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
            UserCommand.PrintHelpMenu();
            AI ai = new AI();
            do
            {
                Console.Write("\nInput: ");
                userInput = Console.ReadLine();
                ai.HandleInput(userInput.ToLower());
            } while (userInput.ToLower() != "quit");
        }
    }
}
