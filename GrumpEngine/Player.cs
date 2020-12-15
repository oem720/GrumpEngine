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
        //Inventory playerInv;
        double health, armorCoefficient;

        GridPositionPoint currentPos;

        public Player(double startHealth, double startArmorVal)
        {
            health = startHealth;
            armorCoefficient = startArmorVal;
            currentPos = new GridPositionPoint(0, 0);
        }
        
        public void MovePlayer(int spaces, Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    currentPos.SetCoordinates(currentPos.X, currentPos.Y + spaces);
                    break;

                case Directions.South:
                    currentPos.SetCoordinates(currentPos.X, currentPos.Y - spaces);
                    break;

                case Directions.East:
                    currentPos.SetCoordinates(currentPos.X + spaces, currentPos.Y);
                    break;

                case Directions.West:
                    currentPos.SetCoordinates(currentPos.X - spaces, currentPos.Y);
                    break;
            }
        }
    }
}
