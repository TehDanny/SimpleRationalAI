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

        public DataStorage()
        {
            allObjects = new List<UserdefinedObject>();
            allTypes = new List<UserdefinedType>();
        }

        public void CreateObject(string inputObjectName)
        {
            if (GetObject(inputObjectName) != null)
                throw new Exception();

            UserdefinedObject o = new UserdefinedObject(inputObjectName);
            allObjects.Add(o);
        }

        public UserdefinedObject GetObject(string inputObjectName)
        {
            foreach (var item in allObjects)
            {
                if (item.Name == inputObjectName)
                    return item;
            }
            return null;
        }

        public void AddType(ref UserdefinedObject o, string inputType)
        {
            UserdefinedType type = new UserdefinedType(inputType);
            o.Types.Add(type);
            bool typeIsNew = CheckIfTypeExistsInAllTypes(type);
            if (typeIsNew == true)
                allTypes.Add(type);
        }

        private bool CheckIfTypeExistsInAllTypes(UserdefinedType type)
        {
            foreach (var item in allTypes)
            {
                if (item.Name == type.Name)
                    return true;
            }
            return false;
        }

        public UserdefinedType GetType(UserdefinedObject o, string inputType)
        {
            foreach (var item in o.Types)
            {
                if (item.Name == inputType)
                    return item;
            }
            return null;
        }

        public void AddVerb(ref UserdefinedObject o, string inputVerb)
        {
            UserdefinedVerb verb = new UserdefinedVerb(inputVerb);

        }

        public UserdefinedVerb GetVerb(UserdefinedObject o, string inputVerb)
        {
            foreach (var item in o.Verbs)
            {
                if (item.Name == inputVerb)
                    return item;
            }
            return null;
        }

        internal void AddVerbToType(string inputVerb, string inputType)
        {
            throw new NotImplementedException();
        }
    }
}
