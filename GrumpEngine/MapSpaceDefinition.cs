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
            mapSpace.Fill(new Tile(0));
        }

        /// <summary>
        /// Fills the map with the value inputted. It will be filled to capacity, and manual editing of the map will be required.
        /// </summary>
        /// <param name="num"></param>
        public void PopulateValues(int num)
        {
            mapSpace.Fill(new Tile(num));
        }

        /// <summary>
        /// Edits a specific point on the map at the coordinates listed within the coordinates passed to it.
        /// Sets the value at that point to the EncounterType passed to the method.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="num"></param>
        public void EditPoint(int row, int col, Tile num)
        {
            mapSpace.Replace(num, row, col);
        }

        /// <summary>
        /// Adds a column to the current map space.
        /// </summary>
        public bool AddColumn()
        {
            mapSpace.AddCol();

            for(int i = 0; i < mapSpace.GetLength(0); i++)
            {
                mapSpace.Add(new Tile(0));
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
                mapSpace.Add(new Tile(0));
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
        /// Returns the value at the point passed to it using cartesian.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public Tile GetTileValue(GridPositionPoint pos)
        {
            return mapSpace.GetValue(mapSpace.GetLength(0) - (1 + pos.Y), pos.X);
        }

        /// <summary>
        /// Gets the tile at the specified x and y values, using matrix coords rather than cartesian
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ref Tile GetTileValue(int x, int y)
        {
            return ref mapSpace.GetValue(x, y);
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

        /// <summary>
        /// Edits the encounter tile at the given position allowing you to add either a new descriptor or a new Entity
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="newDescriptor"></param>
        /// <param name="newEnt"></param>
        public void EditEncounterTile(ref Tile et, DescriptorString newDescriptor = null, Entity newEnt = null)
        {
            if(newDescriptor != null)
            {
                et.AddDescriptorString(newDescriptor);                
            }
            if(newEnt != null)
            {
                et.AddEntity(newEnt);
            }
        }

        public override string ToString()
        {
            return mapSpace.ToString();
        }
    }
}
