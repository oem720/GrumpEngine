using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    enum Directions
    {
        North,
        South,
        East,
        West
    }

    class Player
    {
        private Inventory playerInv;
        private double health, armorCoefficient;

        public Player(double startHealth, double startArmorVal)
        {
            health = startHealth;
            armorCoefficient = startArmorVal;
            Position = new GridPoint(0, 0);
        }

        public GridPoint Position { get; set; }
        
        public void MovePlayer(int spaces, Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    Position.Y += spaces;
                    break;

                case Directions.South:
                    Position.Y -= spaces;
                    break;

                case Directions.East:
                    Position.X += spaces;
                    break;

                case Directions.West:
                    Position.X -= spaces;
                    break;
            }
        }
    }
}
