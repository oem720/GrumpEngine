using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class Inventory
    {
        
        /// <summary>
        /// Overloaded constructor for creating a new inventory.
        /// </summary>
        /// <param name="input"></param>
        public Inventory(int input = 0)
        {
            CarryCapacity = input;
            CurrentCarryWeight = input;
        }
        
        public int CarryCapacity { get; set; }
        public float CurrentCarryWeight { get; private set; }
        public List<IEntity> Inv { get; private set; } = new List<IEntity>();

        /// <summary>
        /// Adds a single item to inventory if there is room available.
        /// </summary>
        /// <param name="e"></param>
        public bool AddItem(IEntity e)
        {
            if (CurrentCarryWeight + e.Weight > CarryCapacity)
            {
                Inv.Add(e);
                EventCoordinator.RaiseEvent(this, EventHandle.On_Item_Added);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes a single item from inventory if int is not set.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="amount"></param>
        public void RemoveItem(IEntity e, int amount = 1)
        {
            int counter = 0;
            for (int i = 0; i < Inv.Count; i++)
            {
                if (counter == amount)
                    break;
                if (Inv.ElementAt(i) == e)
                {
                    counter++;
                    CurrentCarryWeight -= e.Weight;
                    Inv.RemoveAt(i);
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Item_Removed);
                }
            }
        }
    }
}
