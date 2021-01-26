using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class GridPoint
    {
        public GridPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public GridPoint(GridPoint other)
        {
            this.X = other.X;
            this.Y = other.Y;
        }

        public int X { get; set; } = 0;

        public int Y { get; set; } = 0;

        public double DistanceTo(GridPoint other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }

        public double DistanceTo(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2));
        }

        public int TaxicabDistanceTo(GridPoint other)
        {
            return (other.X - X) + (other.Y - Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static GridPoint operator -(GridPoint a, GridPoint b)
        {
            return new GridPoint(a.X - b.X, a.Y - b.Y);
        }

        public static GridPoint operator +(GridPoint a, GridPoint b)
        {
            return new GridPoint(a.X + b.X, a.Y + b.Y);
        }

        public static GridPoint operator *(GridPoint a, GridPoint b)
        {
            return new GridPoint(a.X * b.X, a.Y * b.Y);
        }

        public static GridPoint operator /(GridPoint a, GridPoint b)
        {
            if(b.X == 0 || b.Y == 0)
            {
                throw new DivideByZeroException();
            }

            return new GridPoint((int)(a.X / b.X), (int)(a.Y / b.Y));
        }
    }    
}
