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
                    UserdefinedType typeCheck = dataStorage.GetType(o, inputType);
                    if (typeCheck == null)
                    {
                        dataStorage.AddType(ref o, inputType);
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
                string inputObject = userInput.Split(delimiter)[0];
                string inputVerb = userInput.Split(delimiter)[2];
                UserdefinedObject o = dataStorage.GetObject(inputObject);
                if (o != null)
                {
                    UserdefinedVerb verbCheck = dataStorage.GetVerb(o, inputVerb);
                    if (verbCheck == null)
                    {
                        dataStorage.AddVerb(ref o, inputVerb);
                        Console.WriteLine("The verb called {0} has been added to the object called {1}.", inputVerb, inputObject);
                    }
                    else
                    {
                        Console.WriteLine("The verb you try to add to object {0} has already been added.", inputObject);
                    }
                }
                else
                {
                    Console.WriteLine("The object you try to define doesn't exist.");
                }
            }
            else if (userInput.Split(delimiter)[0] == "all" && userInput.Split(delimiter)[2] == "can" && wordCount == 4) // Add verb to type command
            {
                string inputType = userInput.Split(delimiter)[1];
                string inputVerb = userInput.Split(delimiter)[3];
                dataStorage.AddVerbToType(inputVerb, inputType);
            }
            else
            {
                Console.WriteLine("Syntax invalid.");
            }
            
        }
    }
}
