using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class Tile
    {
        public void AddDescriptorString(DescriptorString entry)
        {
            Descriptors.Add(entry);
            if(OutwardValue == 0)
                OutwardValue = 1;
        }

        public void AddEntity(IEntity entry)
        {
            EntityRegistry.Add(entry);
            if (OutwardValue == 0)
                OutwardValue = 1;
        }

        public DescriptorString RequestString(int index)
        {
            return Descriptors.ElementAt(index);
        }

        public IEntity RequestEntity(int index)
        {
            return EntityRegistry.ElementAt(index);
        }

        public int OutwardValue { get; private set; } = 0;

        public List<DescriptorString> Descriptors { get; private set; } = new List<DescriptorString>();

        public List<IEntity> EntityRegistry { get; private set; } = new List<IEntity>();
    }
}
