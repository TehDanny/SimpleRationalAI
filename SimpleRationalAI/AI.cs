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
            int wordCount = userInput.Split(' ').Length;

            if (wordCount < 2 || wordCount > 4)
                Console.WriteLine("Invalid syntax.");
            else if (userInput.Split(' ')[0] == "create" && wordCount == 2) // Create object command
            {
                CreateObject(userInput);
            }
            else if (userInput.Split(' ')[1] == "is" && wordCount == 3) // Add type to object command
            {
                AddTypeToObject(userInput);
            }
            else if (userInput.Split(' ')[1] == "can" && wordCount == 3) // Add verb to object command
            {
                AddVerbToObject(userInput);
            }
            else if (userInput.Split(' ')[0] == "all" && userInput.Split(' ')[2] == "can" && wordCount == 4) // Add verb to type command
            {
                AddVerbToType(userInput);
            }
            else
            {
                Console.WriteLine("Syntax invalid.");
            }
        }

        private void CreateObject(string userInput)
        {
            try
            {
                string objectName = userInput.Split(' ')[1];
                dataStorage.CreateObject(objectName);
                Console.WriteLine("An object called {0} has been created", objectName);
            }
            catch (Exception)
            {
                Console.WriteLine("The object you try to create already exists.");
            }
        }

        private void AddTypeToObject(string userInput)
        {
            string inputObject = userInput.Split(' ')[0];
            string inputType = userInput.Split(' ')[2];
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

        private void AddVerbToObject(string userInput)
        {
            string inputObject = userInput.Split(' ')[0];
            string inputVerb = userInput.Split(' ')[2];
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

        private void AddVerbToType(string userInput)
        {
            string inputType = userInput.Split(' ')[1];
            string inputVerb = userInput.Split(' ')[3];
            dataStorage.AddVerbToType(inputVerb, inputType);
        }
    }
}
