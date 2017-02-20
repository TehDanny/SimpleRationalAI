using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRationalAI
{
    class UserdefinedVerb
    {
        public string Name { get; set; }
        public List<UserdefinedObject> Objects = new List<UserdefinedObject>();
        public List<UserdefinedType> Types = new List<UserdefinedType>();
    }
}
