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

            UserdefinedObject o = new UserdefinedObject(inputObject);
            allObjects.Add(o);
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

        public void AddTypeToObject(ref UserdefinedObject o, string inputType)
        {
            UserdefinedType type = new UserdefinedType(inputType);
            o.Types.Add(type);
            bool typeIsNew = CheckIfTypeExistsInAllTypes(inputType);
            if (typeIsNew == true)
                allTypes.Add(type);
        }

        private bool CheckIfTypeExistsInAllTypes(string inputType) // Change to GetTypeFromAllTypes(string inputType)
        {
            foreach (var item in allTypes)
            {
                if (item.Name == inputType)
                    return true;
            }
            return false;
        }

        public UserdefinedType GetTypeFromObject(UserdefinedObject o, string inputType)
        {
            foreach (var item in o.Types)
            {
                if (item.Name == inputType)
                    return item;
            }
            return null;
        }

        public void AddVerbToObject(ref UserdefinedObject o, string inputVerb)
        {
            UserdefinedVerb verb = new UserdefinedVerb(inputVerb);
            o.Verbs.Add(verb);
            allVerbs.Add(verb);
        }

        public UserdefinedVerb GetVerbFromObject(UserdefinedObject o, string inputVerb)
        {
            foreach (var item in o.Verbs)
            {
                if (item.Name == inputVerb)
                    return item;
            }
            return null;
        }

        private bool CheckIfVerbExistsInAllVerbs(string inputVerb) // Change to GetVerbFromAllVerbs(string inputVerb)
        {
            foreach (var item in allVerbs)
            {
                if (item.Name == inputVerb)
                    return true;
            }
            return false;
        }

        internal void AddVerbToType(string inputVerb, string inputType)
        {
            throw new NotImplementedException();
            CheckIfVerbExistsInAllVerbs(inputVerb);
            CheckIfTypeExistsInAllTypes(inputType);
        }
    }
}
