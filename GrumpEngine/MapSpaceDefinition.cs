using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class MapSpaceDefinition
    {
        private ResizeableMatrix<Tile> mapSpace;

        public ResizeableMatrix<Tile> Map
        {
            get { return mapSpace; }
        }

        /// <summary>
        /// Creates a new map space using the parameters of rows and cols.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public MapSpaceDefinition(int row, int col)
        {
            mapSpace = new ResizeableMatrix<Tile>(row, col);
            mapSpace.Fill(new Tile());
        }

        /// <summary>
        /// Fills the map with the value inputted. It will be filled to capacity, and manual editing of the map will be required.
        /// </summary>
        /// <param name="num"></param>
        public void PopulateValues()
        {
            mapSpace.Fill(new Tile());
        }

        /// <summary>
        /// Adds a column to the current map space.
        /// </summary>
        public bool AddColumn()
        {
            mapSpace.AddCol();

            for(int i = 0; i < mapSpace.GetLength(0); i++)
            {
                mapSpace.Add(new Tile());
            }

            return true;
        }

        /// <summary>
        /// Adds a row to the current map space.
        /// </summary>
        public bool AddRow()
        {
            mapSpace.AddRow();

            for(int i = 0; i < mapSpace.GetLength(1); i++)
            {
                mapSpace.Add(new Tile());
            }

            return true;
        }

        /// <summary>
        /// Removes a column from the current map space.
        /// </summary>
        /// <returns></returns>
        public bool RemoveCol()
        {
            return mapSpace.RemoveCol();
        }

        /// <summary>
        /// Removes a row from the current map space.
        /// </summary>
        /// <returns></returns>
        public bool RemoveRow()
        {
            return mapSpace.RemoveRow();
        }

        /// <summary>
        /// returns the length of the specified dimension.
        /// </summary>
        /// <param name="dimension"></param>
        /// <returns></returns>
        public int GetLength(int dimension)
        {
            return mapSpace.GetLength(dimension);
        }

        public Tile this[int i, int j]
        {
            get => mapSpace[i, j];
            set => mapSpace[i, j] = value;
        }

        public Tile this[GridPositionPoint pos]
        {
            get => mapSpace[pos.X, pos.Y];
            set => mapSpace[pos.X, pos.Y] = value;
        }
    }
}
