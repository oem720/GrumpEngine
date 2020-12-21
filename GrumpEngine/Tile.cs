using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class Tile
    {
        int outwardVisibleValue;
        List<DescriptorString> descriptorRegistry;
        List<Entity> entityRegistry;

        public Tile(int value)
        {
            outwardVisibleValue = value;
            descriptorRegistry = new List<DescriptorString>();
            entityRegistry = new List<Entity>();
        }

        public void AddDescriptorString(DescriptorString entry)
        {
            descriptorRegistry.Add(entry);
        }

        public void AddEntity(Entity entry)
        {
            entityRegistry.Add(entry);
        }

        public DescriptorString RequestString(int index)
        {
            return descriptorRegistry.ElementAt(index);
        }

        public Entity RequestEntity(int index)
        {
            return entityRegistry.ElementAt(index);
        }

        public int OutwardValue
        {
            get { return outwardVisibleValue; }
            set { outwardVisibleValue = value; }
        }

        public List<DescriptorString> Descriptors
        {
            get { return descriptorRegistry; }
        }

        public List<Entity> EntityRegistry
        {
            get { return entityRegistry; }
        }

        public override string ToString()
        {
            return "" + outwardVisibleValue;
        }
    }
}
