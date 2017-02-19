using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    static class AI
    {
        public static void HandleInput(string userInput)
        {
            char delimiter = ' ';
            int wordCount = userInput.Split(delimiter).Length;

            if (userInput.Split(delimiter)[0] == "create" && wordCount == 2)
            {
                string objectName = userInput.Split(delimiter)[1];
                UserdefinedObject o = new UserdefinedObject(objectName);
                Console.WriteLine("An object called {0} has been created", objectName);
            }
        }
    }
}
