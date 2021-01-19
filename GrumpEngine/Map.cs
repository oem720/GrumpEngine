using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class Map
    {
        public ResizeableMatrix<Tile> MapGrid { get; private set; }

        /// <summary>
        /// Creates a new map space using the parameters of rows and cols.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Map(int row, int col)
        {
            MapGrid = Factory.ConstructResizeableMatrix<Tile>(row, col);
            MapGrid.Fill(Factory.ConstructTile());
        }

        /// <summary>
        /// Adds a column to the current map space.
        /// </summary>
        public bool AddColumn()
        {
            MapGrid.AddCol();

            for(int i = 0; i < MapGrid.GetLength(0); i++)
                MapGrid.Add(Factory.ConstructTile());

            return true;
        }

        /// <summary>
        /// Adds a row to the current map space.
        /// </summary>
        public bool AddRow()
        {
            MapGrid.AddRow();

            for(int i = 0; i < MapGrid.GetLength(1); i++)
                MapGrid.Add(Factory.ConstructTile());

            return true;
        }

        /// <summary>
        /// Removes a column from the current map space.
        /// </summary>
        /// <returns></returns>
        public bool RemoveCol()
        {
            return MapGrid.RemoveCol();
        }

        /// <summary>
        /// Removes a row from the current map space.
        /// </summary>
        /// <returns></returns>
        public bool RemoveRow()
        {
            return MapGrid.RemoveRow();
        }

        /// <summary>
        /// returns the length of the specified dimension.
        /// </summary>
        /// <param name="dimension"></param>
        /// <returns></returns>
        public int GetLength(int dimension)
        {
            return MapGrid.GetLength(dimension);
        }

        public Tile this[int i, int j]
        {
            get => MapGrid[i, j];
            set => MapGrid[i, j] = value;
        }

        public Tile this[GridPoint pos]
        {
            get => MapGrid[pos.X, pos.Y];
            set => MapGrid[pos.X, pos.Y] = value;
        }
    }
}
