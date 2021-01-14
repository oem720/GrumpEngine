using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    class Inventory
    {
        private float size;
        private float currentSize;
        private List<Entity> inventory = new List<Entity>();
        /// <summary>
        /// Overloaded constructor for creating a new inventory.
        /// </summary>
        /// <param name="input"></param>
        public Inventory(int input = 0)
        {
            size = input;
            currentSize = input;
        }
        /// <summary>
        /// Returns the max size of the inventory.
        /// </summary>
        /// <returns></returns>
        public float GetSize()
        {
            return size;
        }
        /// <summary>
        /// Returns the current weight of inventory.
        /// </summary>
        /// <returns></returns>
        public float GetCurrentSize()
        {
            return currentSize;
        }
        /// <summary>
        /// Returns the inventory as List<Entity>.
        /// </summary>
        /// <returns></returns>
        public List<Entity> GetInventory()
        {
            return inventory;
        }
        /// <summary>
        /// Sets the new max size of the inventory.
        /// </summary>
        /// <param name="input"></param>
        public void setSize(float input)
        {
            size = input;
        }
        /// <summary>
        /// Adds a single item to inventory if there is room available.
        /// </summary>
        /// <param name="e"></param>
        public void addItem(Entity e)
        {
            if (currentSize + e.Weight > size)
                inventory.Add(e);
        }
        /// <summary>
        /// Removes a single item from inventory if int is not set.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="amount"></param>
        public void removeItem(Entity e, int amount = 1)
        {
            int counter = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (counter == amount)
                    break;
                if (inventory.ElementAt(i) == e)
                {
                    counter++;
                    currentSize -= e.Weight;
                    inventory.RemoveAt(i);
                }
            }
        }
    }
}
