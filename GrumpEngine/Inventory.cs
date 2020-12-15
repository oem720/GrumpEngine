using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    class Inventory
    {
        private int size;
        private Entity[] inv;
        public Inventory()
        {
            size = 0;
            inv = new Entity[0];
        }
        public Inventory(int input)
        {
            size = input;
            inv = new Entity[input];
        }
        public int GetSize()
        {
            return size;
        }
        public Entity[] GetInventory()
        {
            return inv;
        }
        public void addItem(Entity e)
        {
            e.GetWeight();
        }
    }
}
