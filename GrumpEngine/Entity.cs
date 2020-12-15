using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    class Entity
    {
        int typeSetter;
        string[] args;

        public Entity(int type)
        {
            typeSetter = type;
        }

        public Entity(int type, string[] specialArgs)
        {
            typeSetter = type;
            args = specialArgs;
        }
    }
}
