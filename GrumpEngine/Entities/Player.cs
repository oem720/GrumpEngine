using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class Player : ICharacter
    {
        //implement the required properties for ICharacter
        public int Health { get; private set; } = 25;
        public double DamageResistance { get; private set; } = 0.0;
        public int Level { get; private set; } = 1;
        public DialogueTree Dialogue { get; private set; } = null;
        public bool IsTalkable { get; private set; } = false;
        public Inventory Inv { get; private set; } = new Inventory();

        //implement the required properties for IEntity
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "Player";
        public bool IsGrabbable { get; set; } = false;

        //Member Auto-Props
        public string Name { get; private set; }
        public int XP { get; set; } = 0;

        //Member Fields
        private int _requiredXPToLevel;
        private GridPoint _currentPos;

        public Player(GridPoint pos, string name = "Player")
        {
            Name = name;
            _currentPos = pos;
            _requiredXPToLevel = 100;
        }

        /// <summary>
        /// Grant the player XP, amount. If the amount is enough to level them up, their XP is reset to the remainder of
        /// XP over the required threshold. True is returned if the player leveled up, otherwise, false will be returned.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool GrantXP(int amount)
        {
            XP += amount;
            
            if(XP >= _requiredXPToLevel)
            {
                XP -= _requiredXPToLevel;
                _requiredXPToLevel = (int)(_requiredXPToLevel * 1.5);
                Level++;
                return true;
            }
            return false;
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
                    _currentPos.Y++;
                    break;
                case Directions.South:
                    _currentPos.Y--;
                    break;
                case Directions.East:
                    _currentPos.X++;
                    break;
                case Directions.West:
                    _currentPos.X--;
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
    }
}
