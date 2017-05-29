using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    static class UserCommand
    {
        public static void PrintHelpMenu()
        {
            // Commented out commands are not yet implemented
            Console.WriteLine("Syntax for talking with the AI:");
            Console.WriteLine("Write \"create [object]\" to create an object.");
            Console.WriteLine("Write \"[object] is [type]\" to define the object as a type.");
            Console.WriteLine("Write \"[object] can [verb]\" to define what the object can do.");
            Console.WriteLine("Write \"all [type] can [verb]\" to define what all objects of the type can do.");
            //Console.WriteLine("Write \"can [object] [verb]\" to check if the object can do what you ask.");
            //Console.WriteLine("Write \"what/who can [verb]\" to check which types can do what you ask.");
            //Console.WriteLine("Write \"save ai\" to save the current AI.");
            //Console.WriteLine("Write \"load ai\" to load a saved AI.");
            Console.WriteLine("Write \"help\" to show the available commands again.");
        }
    }
}
