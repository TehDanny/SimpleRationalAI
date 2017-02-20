using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class UserdefinedType
    {
        public string Name { get; set; }
        public List<UserdefinedObject> Objects = new List<UserdefinedObject>();
        public List<UserdefinedVerb> Verbs = new List<UserdefinedVerb>();

        public UserdefinedType(string name)
        {
            Name = name;
        }
    }
}
