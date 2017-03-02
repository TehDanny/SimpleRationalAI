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
        public List<UserdefinedType> Types = new List<UserdefinedType>();
        public List<UserdefinedVerb> Verbs = new List<UserdefinedVerb>();

        public UserdefinedObject(string name)
        {
            Name = name;
        }
    }
}
