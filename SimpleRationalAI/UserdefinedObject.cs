using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class UserdefinedObject
    {
        public string Name { get; set; }
        public List<Type> Types { get; set; }
        public List<UserdefinedVerb> Verbs { get; set; }

        public UserdefinedObject(string name)
        {
            Name = name;
        }

        public UserdefinedObject()
        {

        }
    }
}
