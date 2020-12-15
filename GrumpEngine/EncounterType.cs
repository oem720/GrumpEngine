using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class EncounterType
    {
        int outwardVisibleValue;
        List<String> descriptors;
        List<Entity> entityReg;

        public EncounterType(int value)
        {
            outwardVisibleValue = value;
        }

        public EncounterType(int value, List<string> strings)
        {
            outwardVisibleValue = value;
            descriptors = strings;
        }

        public EncounterType(int value, List<string> strings, List<Entity> newReg)
        {
            outwardVisibleValue = value;
            descriptors = strings;
            entityReg = newReg;
        }

        public void AddDescriptorString(string entry)
        {
            descriptors.Add(entry);
        }

        public void AddEntity(Entity entry)
        {
            entityReg.Add(entry);
        }

        public string RequestString(int index)
        {
            return descriptors.ElementAt(index);
        }

        public Entity RequestEntity(int index)
        {
            return entityReg.ElementAt(index);
        }

        public override string ToString()
        {
            return "" + outwardVisibleValue;
        }
    }
}
