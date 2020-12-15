using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class GridPositionPoint
    {
        private int posX, posY;

        public GridPositionPoint()
        {
            posX = 0;
            posY = 0;
        }

        public GridPositionPoint(int x)
        {
            posX = x;
        }

        public GridPositionPoint(int x, int y)
        {
            posX = x;
            posY = y;
        }

        public GridPositionPoint(GridPositionPoint other)
        {
            posX = other.X;
            posY = other.Y;
        }

        public int X
        {
            get { return posX; }
            set { posX = value; }
        }

        public int Y
        {
            get { return posY; }
            set { posY = value; }
        }

        public void SetCoordinates(int newX, int newY)
        {
            posX = newX;
            posY = newY;
        }

        public void SetCoordinates(GridPositionPoint other)
        {
            posX = other.X;
            posY = other.Y;
        }

        public double DistanceTo(GridPositionPoint other)
        {
            return Math.Sqrt(Math.Pow(other.X - posX, 2) + Math.Pow(other.Y - posY, 2));
        }

        public double DistanceTo(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x - posX, 2) + Math.Pow(y - posY, 2));
        }

        public int TaxicabDistanceTo(GridPositionPoint other)
        {
            return (other.X - posX) + (other.Y - posY);
        }

        public override string ToString()
        {
            return $"({posX}, {posY})";
        }

        public static GridPositionPoint operator -(GridPositionPoint a, GridPositionPoint b)
        {
            return new GridPositionPoint(a.X - b.X, a.Y - b.Y);
        }

        public static GridPositionPoint operator +(GridPositionPoint a, GridPositionPoint b)
        {
            return new GridPositionPoint(a.X + b.X, a.Y + b.Y);
        }

        public static GridPositionPoint operator *(GridPositionPoint a, GridPositionPoint b)
        {
            return new GridPositionPoint(a.X * b.X, a.Y * b.Y);
        }

        public static GridPositionPoint operator /(GridPositionPoint a, GridPositionPoint b)
        {
            if(b.X == 0 || b.Y == 0)
            {
                throw new DivideByZeroException();
            }

            return new GridPositionPoint((int)(a.X / b.X), (int)(a.Y / b.Y));
        }
    }    
}
