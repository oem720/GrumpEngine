using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    class MapSpaceDefinition
    {
        private ResizeableMatrix mapSpace;

        /// <summary>
        /// Creates a new map space using the parameters of rows and cols.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public MapSpaceDefinition(int row, int col)
        {
            mapSpace = new ResizeableMatrix(row, col);
        }

        /// <summary>
        /// Fills the map with the value inputted. It will be filled to capacity, and manual editing of the map will be required.
        /// </summary>
        /// <param name="num"></param>
        public void PopulateValues(int num)
        {
            mapSpace.Fill(num);
        }

        /// <summary>
        /// Edits a specific point on the map at the coordinates listed within the GridPositionPoint passed to it.
        /// Sets the value at that point to the EncounterType passed to the method.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="num"></param>
        public void EditPoint(GridPositionPoint point, EncounterType num)
        {
            mapSpace.Replace(num, mapSpace.GetLength(1) - point.X, mapSpace.GetLength(0) - point.Y);
        }

        /// <summary>
        /// Edits a specific point on the map at the coordinates given in x and y.
        /// Sets the value at that point to the EncounterType passed to the method.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="num"></param>
        public void EditPoint(int x, int y, EncounterType num)
        {
            mapSpace.Replace(num, mapSpace.GetLength(1) - x, mapSpace.GetLength(0) - y);
        }

        public override string ToString()
        {
            return mapSpace.ToString();
        }
    }
}
