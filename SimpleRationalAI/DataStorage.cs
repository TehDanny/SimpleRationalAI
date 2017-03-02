using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class DataStorage
    {
        private List<UserdefinedObject> AllObjects;

        public DataStorage()
        {
            AllObjects = new List<UserdefinedObject>();
        }

        public void CreateObject(string inputObjectName)
        {
            if (GetObject(inputObjectName) != null)
                throw new Exception();

            UserdefinedObject o = new UserdefinedObject(inputObjectName);
            AllObjects.Add(o);
        }

        public UserdefinedObject GetObject(string inputObjectName)
        {
            foreach (var item in AllObjects)
            {
                if (item.Name == inputObjectName)
                    return item;
            }
            return null;
        }

        public void AddType(ref UserdefinedObject o, UserdefinedType type)
        {
            o.Types.Add(type);
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

        public void AddVerb()
        {

        }
    }
}
