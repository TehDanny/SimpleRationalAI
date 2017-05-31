using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class DataStorage
    {
        private List<UserdefinedObject> allObjects;
        private List<UserdefinedType> allTypes;
        private List<UserdefinedVerb> allVerbs;


        public DataStorage()
        {
            allObjects = new List<UserdefinedObject>();
            allTypes = new List<UserdefinedType>();
            allVerbs = new List<UserdefinedVerb>();
        }

        public void CreateObject(string inputObject)
        {
            if (GetObjectFromAllObjects(inputObject) != null)
                throw new Exception();

            UserdefinedObject obj = new UserdefinedObject(inputObject);
            allObjects.Add(obj);
        }

        public UserdefinedObject GetObjectFromAllObjects(string inputObject)
        {
            foreach (var item in allObjects)
            {
                if (item.Name == inputObject)
                    return item;
            }
            return null;
        }

        public void AddTypeToObject(string inputObject, string inputType)
        {
            if (GetObjectFromAllObjects(inputObject) == null)
                throw new Exception();

            if (GetTypeFromAllTypes(inputType) == null)
            {
                UserdefinedType type = new UserdefinedType(inputType);
                allTypes.Add(type);
                // Add the type to the object here, obj.Types.Add(type);
            }
        }

        /*
        public void AddTypeToObject(ref UserdefinedObject obj, string inputType)
        {
            UserdefinedType type = new UserdefinedType(inputType);
            obj.Types.Add(type);
            bool typeIsNew = CheckIfTypeExistsInAllTypes(inputType);
            if (typeIsNew == true)
                allTypes.Add(type);
        }
        */

        private UserdefinedType GetTypeFromAllTypes(string inputType)
        {
            foreach (var item in allTypes)
            {
                if (item.Name == inputType)
                    return item;
            }
            return null;
        }

        /*
        private bool CheckIfTypeExistsInAllTypes(string inputType)
        {
            foreach (var item in allTypes)
            {
                if (item.Name == inputType)
                    return true;
            }
            return false;
        }
        */

        public UserdefinedType GetTypeFromObject(UserdefinedObject obj, string inputType)
        {
            foreach (var item in obj.Types)
            {
                if (item.Name == inputType)
                    return item;
            }
            return null;
        }

        public void AddVerbToObject(ref UserdefinedObject obj, string inputVerb)
        {
            UserdefinedVerb verb = new UserdefinedVerb(inputVerb);
            obj.Verbs.Add(verb);
            allVerbs.Add(verb);
        }

        public UserdefinedVerb GetVerbFromObject(UserdefinedObject obj, string inputVerb)
        {
            foreach (var item in obj.Verbs)
            {
                if (item.Name == inputVerb)
                    return item;
            }
            return null;
        }

        private UserdefinedVerb GetVerbFromAllVerbs(string inputVerb)
        {
            foreach (var item in allVerbs)
            {
                if (item.Name == inputVerb)
                    return item;
            }
            return null;
        }

        /*
        private bool CheckIfVerbExistsInAllVerbs(string inputVerb)
        {
            foreach (var item in allVerbs)
            {
                if (item.Name == inputVerb)
                    return true;
            }
            return false;
        }
        */

        internal void AddVerbToType(string inputVerb, string inputType)
        {
            throw new NotImplementedException();
            GetVerbFromAllVerbs(inputVerb);
            //CheckIfVerbExistsInAllVerbs(inputVerb);
            GetTypeFromAllTypes(inputType);
            //CheckIfTypeExistsInAllTypes(inputType);
        }
    }
}
