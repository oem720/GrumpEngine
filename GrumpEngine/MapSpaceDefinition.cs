using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class MapSpaceDefinition
    {
        public ResizeableMatrix<Tile> Map { get; private set; }

        /// <summary>
        /// Creates a new map space using the parameters of rows and cols.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public MapSpaceDefinition(int row, int col)
        {
            Map = new ResizeableMatrix<Tile>(row, col);
            Map.Fill(new Tile());
        }

        /// <summary>
        /// Fills the map with the value inputted. It will be filled to capacity, and manual editing of the map will be required.
        /// </summary>
        /// <param name="num"></param>
        public void PopulateValues()
        {
            Map.Fill(new Tile());
        }

        /// <summary>
        /// Adds a column to the current map space.
        /// </summary>
        public bool AddColumn()
        {
            Map.AddCol();

            for(int i = 0; i < Map.GetLength(0); i++)
            {
                Map.Add(new Tile());
            }

            return true;
        }

        /// <summary>
        /// Adds a row to the current map space.
        /// </summary>
        public bool AddRow()
        {
            Map.AddRow();

            for(int i = 0; i < Map.GetLength(1); i++)
            {
                Map.Add(new Tile());
            }

            return true;
        }

        /// <summary>
        /// Removes a column from the current map space.
        /// </summary>
        /// <returns></returns>
        public bool RemoveCol()
        {
            return Map.RemoveCol();
        }

        /// <summary>
        /// Removes a row from the current map space.
        /// </summary>
        /// <returns></returns>
        public bool RemoveRow()
        {
            return Map.RemoveRow();
        }

        /// <summary>
        /// returns the length of the specified dimension.
        /// </summary>
        /// <param name="dimension"></param>
        /// <returns></returns>
        public int GetLength(int dimension)
        {
            return Map.GetLength(dimension);
        }

        public Tile this[int i, int j]
        {
            get => Map[i, j];
            set => Map[i, j] = value;
        }

        public Tile this[GridPoint pos]
        {
            get => Map[pos.X, pos.Y];
            set => Map[pos.X, pos.Y] = value;
        }
    }
}
