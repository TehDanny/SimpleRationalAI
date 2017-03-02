using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class AI // could be renamed to ClientHandler
    {
        private DataStorage dataStorage;

        public AI()
        {
            dataStorage = new DataStorage();
        }

        public void HandleInput(string userInput)
        {
            char delimiter = ' ';
            int wordCount = userInput.Split(delimiter).Length;

            if (wordCount == 1)
                Console.WriteLine("Invalid syntax.");
            else if (userInput.Split(delimiter)[0] == "create" && wordCount == 2) // Create object command
            {
                try
                {
                    string objectName = userInput.Split(delimiter)[1];
                    dataStorage.CreateObject(objectName);
                    Console.WriteLine("An object called {0} has been created", objectName);
                }
                catch (Exception)
                {
                    Console.WriteLine("The object you try to create already exists.");
                }
                
            }
            else if (userInput.Split(delimiter)[1] == "is" && wordCount == 3) // Add type to object command
            {
                string inputObject = userInput.Split(delimiter)[0];
                string inputType = userInput.Split(delimiter)[2];
                UserdefinedObject o = dataStorage.GetObject(inputObject);
                if (o != null)
                {
                    UserdefinedType type = dataStorage.GetType(o, inputType);
                    if(type != null)
                    {
                        dataStorage.AddType(o, type);
                        Console.WriteLine("The type called {0} has been added to the object called {1}.", inputType, inputObject);
                    }
                    else
                    {
                        Console.WriteLine("The type you try to add to object {0} has already been added.", inputObject);
                    }
                }
                else
                {
                    Console.WriteLine("The object you try to define doesn't exist.");
                }
            }
            else if (userInput.Split(delimiter)[1] == "can" && wordCount == 3) // Add verb to object command
            {

            }
            else
            {
                Console.WriteLine("Syntax invalid.");
            }
        }
    }
}
