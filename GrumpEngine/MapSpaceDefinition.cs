using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class MapSpaceDefinition
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
            mapSpace.Replace(num, mapSpace.GetLength(0) - (1 + point.Y), point.X);
        }

        /// <summary>
        /// Adds a column to the current map space.
        /// </summary>
        public void AddColumn()
        {
            mapSpace.ResizeColSize();
        }

        /// <summary>
        /// Adds a row to the current map space.
        /// </summary>
        public void AddRow()
        {
            mapSpace.ResizeRowSize();
        }

        /// <summary>
        /// Returns the value at the point passed to it.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public EncounterType GetTileValues(GridPositionPoint pos)
        {
            return mapSpace.GetEncounter(mapSpace.GetLength(0) - (1 + pos.Y), pos.X);
        }

        /// <summary>
        /// Edits the encounter tile at the given position allowing you to add either a new descriptor or a new Entity
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="newDescriptor"></param>
        /// <param name="newEnt"></param>
        public void EditEncounterTile(GridPositionPoint pos, string newDescriptor = null, Entity newEnt = null)
        {
            EncounterType editedPoint = GetTileValues(pos);

            if(newDescriptor != null)
            {
                editedPoint.AddDescriptorString(newDescriptor);                
            }
            if(newEnt != null)
            {
                editedPoint.AddEntity(newEnt);
            }
        }

        /// <summary>
        /// Adds a column to the current map space.
        /// </summary>
        public void AddColumn()
        {
            mapSpace.ResizeColSize();
        }

        /// <summary>
        /// Adds a row to the current map space.
        /// </summary>
        public void AddRow()
        {
            mapSpace.ResizeRowSize();
        }

        /// <summary>
        /// Returns the value at the point passed to it.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public EncounterType GetTileValues(GridPositionPoint pos)
        {
            return mapSpace.GetEncounter(mapSpace.GetLength(0) - (1 + pos.Y), pos.X);
        }

        /// <summary>
        /// Edits the encounter tile at the given position allowing you to add either a new descriptor or a new Entity
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="newDescriptor"></param>
        /// <param name="newEnt"></param>
        public void EditEncounterTile(GridPositionPoint pos, string newDescriptor = null, Entity newEnt = null)
        {
            EncounterType editedPoint = GetTileValues(pos);

            if(newDescriptor != null)
            {
                editedPoint.AddDescriptorString(newDescriptor);                
            }
            if(newEnt != null)
            {
                editedPoint.AddEntity(newEnt);
            }
        }

        public override string ToString()
        {
            return mapSpace.ToString();
        }
    }
}
