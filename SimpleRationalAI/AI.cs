using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class AI // could be renamed to ClientHandler
    {
        private List<UserdefinedObject> AllObjects; // could be moved to a data class

        public AI()
        {
            AllObjects = new List<UserdefinedObject>();
        }

        public void HandleInput(string userInput)
        {
            char delimiter = ' ';
            int wordCount = userInput.Split(delimiter).Length;

            if (userInput.Split(delimiter)[0] == "create" && wordCount == 2)
            {
                string objectName = userInput.Split(delimiter)[1];
                UserdefinedObject o = new UserdefinedObject(objectName);
                AllObjects.Add(o);
                Console.WriteLine("An object called {0} has been created", objectName);
            }
            else if(userInput.Split(delimiter)[1] == "is" && wordCount == 3)
            {
                string inputObject = userInput.Split(delimiter)[0];
                string inputType = userInput.Split(delimiter)[2];
                bool objectExists = false;
                bool typeAlreadyDefined = false;
                UserdefinedObject actualObject = null;
                UserdefinedType actualType = null;

                foreach (var item in AllObjects) // should be in the helper class
                {
                    if (inputObject == item.Name)
                    {
                        actualObject = item;
                        objectExists = true;
                        // return true, in helper class
                    }
                }
                if (objectExists == true)
                {
                        foreach (var item in actualObject.Types) // should be in the helper class
                        {
                            if (inputType == item.Name)
                            {
                                typeAlreadyDefined = true;
                                // return true, in helper class
                            }
                        }
                    if(typeAlreadyDefined==false)
                    {
                        actualType = new UserdefinedType(inputType);
                        actualObject.Types.Add(actualType);
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
            else
            {
                Console.WriteLine("Syntax invalid.");
            }
        }
    }
}
