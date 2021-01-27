using System;
using System.Collections.Generic;

namespace GrumpEngine
{
    [Serializable]
    public class Player : ICharacter
    {
        //implement the required properties for ICharacter
        public int Health { get; private set; } = 25;
        public float DamageResistance { get; private set; } = 0.0f;
        public int Level { get; private set; } = 1;
        public DialogueTree Dialogue { get; private set; } = null;
        public bool IsTalkable { get; private set; } = false;
        public Inventory Inv { get; private set; } = Factory.ConstructInventory(10);
        public Weapon CurrentEquippedWeapon { get; private set; }
        public Armor CurrentEquippedArmor { get; private set; }

        //implement the required properties for IEntity
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "Player";
        public bool IsGrabbable { get; set; } = false;

        //Member Auto-Props
        public string Name { get; private set; }
        public int XP { get; set; } = 0;
        public PlayerClass Class { get; set; }
        public GridPoint CurrentPosition { get; private set; }
        public int RequiredXPToLevel { get; set; } = 100;
        public int Gold { get; set; }
        public AssistItem CurrentEquippedAssistItem { get; private set; }
        public int MaxHealth { get; set; }
        public Dictionary<PlayerStat, int> Stats { get; set; } = Factory.GenerateStats();

        public Player(GridPoint pos, int maxhealth, string name = "Player")
        {
            Name = name;
            CurrentPosition = pos;
            MaxHealth = maxhealth;
            Health = MaxHealth;
            RequiredXPToLevel = 100;
        }

        /// <summary>
        /// Grant the player XP, amount. If the amount is enough to level them up, their XP is reset to the remainder of
        /// XP over the required threshold. True is returned if the player leveled up, otherwise, false will be returned.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool GrantXP(int amount)
        {
            bool isLeveledUp = false;
            XP += amount;
            EventCoordinator.RaiseEvent(this, EventHandle.On_Player_XP_Granted);

            while(XP >= RequiredXPToLevel)
            {
                if (XP >= RequiredXPToLevel)
                {
                    XP -= RequiredXPToLevel;
                    RequiredXPToLevel = (int)(RequiredXPToLevel * 1.5);
                    Level++;
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Player_Level_Up);
                    isLeveledUp = true;
                }
            }
            
            return isLeveledUp;
        }

        public void Heal(int val)
        {
            if(val < 0)
            {
                Health += val;
                EventCoordinator.RaiseEvent(this, EventHandle.On_Player_Hit);
            }
            else
            {
                int diff = MaxHealth - Health;
                if (val > diff)
                    Health = MaxHealth;
                else
                    Health += val;
                EventCoordinator.RaiseEvent(this, EventHandle.On_Player_Healed);
            }
        }

        /// <summary>
        /// Moves the player in the given direction
        /// </summary>
        /// <param name="dir"></param>
        public void Move(Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Tile_Exit, CurrentPosition, Directions.North);
                    CurrentPosition.Y++;
                    break;
                case Directions.South:
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Tile_Exit, CurrentPosition, Directions.South);
                    CurrentPosition.Y--;                    
                    break;
                case Directions.East:
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Tile_Exit, CurrentPosition, Directions.East);
                    CurrentPosition.X++;
                    break;
                case Directions.West:
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Tile_Exit, CurrentPosition, Directions.West);
                    CurrentPosition.X--;
                    break;
            }                
        }

        /// <summary>
        /// Adds the item to their inventory, returning true if it was successfully added and false if not.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool PickUpItem(IEntity item)
        {
            return Inv.AddItem(item);
        }

        /// <summary>
        /// Adds the weapon from the inventory, removing it from inventory and putting it into the CurrentEquippedWeapon slot.
        /// If there is a weapon already in hand, that is automatically placed into the inventory
        /// </summary>
        /// <param name="wep"></param>
        public void EquipWeapon(Weapon wep)
        {
            if (CurrentEquippedWeapon != null)
                UnequipCurrentWeapon();

            CurrentEquippedWeapon = wep;
            Inv.RemoveItem(wep);
            EventCoordinator.RaiseEvent(this, EventHandle.On_Weapon_Equipped);
        }

        public void UnequipCurrentWeapon()
        {
            Inv.AddItem(CurrentEquippedWeapon);
            CurrentEquippedWeapon = null;
            EventCoordinator.RaiseEvent(this, EventHandle.On_Weapon_Unequipped);
        }

        public void EquipArmor(Armor arm)
        {
            if (CurrentEquippedArmor != null)
                UnequipCurrentArmor();

            CurrentEquippedArmor = arm;
            Inv.RemoveItem(arm);
            EventCoordinator.RaiseEvent(this, EventHandle.On_Armor_Equipped);
        }

        public void UnequipCurrentArmor()
        {
            Inv.AddItem(CurrentEquippedArmor);
            CurrentEquippedArmor = null;
            EventCoordinator.RaiseEvent(this, EventHandle.On_Armor_Unequipped);
        }

        public void EquipAssistItem(AssistItem ai)
        {
            if (CurrentEquippedAssistItem != null)
                UnequipAssistItem();

            CurrentEquippedAssistItem = ai;
            Stats[CurrentEquippedAssistItem.Bonus.Key] += CurrentEquippedAssistItem.Bonus.Value;
            Inv.RemoveItem(ai);
            EventCoordinator.RaiseEvent(this, EventHandle.On_Support_Item_Equipped);
        }

        public void UnequipAssistItem()
        {
            Stats[CurrentEquippedAssistItem.Bonus.Key] -= CurrentEquippedAssistItem.Bonus.Value;
            Inv.AddItem(CurrentEquippedAssistItem);
            CurrentEquippedAssistItem = null;
            EventCoordinator.RaiseEvent(this, EventHandle.On_Support_Item_Unequipped);
        }
    }
}
