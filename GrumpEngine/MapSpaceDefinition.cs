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

        public MapSpaceDefinition(int row, int col)
        {
            mapSpace = new ResizeableMatrix(row, col);
        }

        public void PopulateValues(int num)
        {
            mapSpace.Fill(num);
        }

        public void EditPoint(GridPositionPoint point, EncounterType num)
        {
            mapSpace.Replace(num, point.X, point.Y);
        }

        public void EditPoint(int x, int y, EncounterType num)
        {
            mapSpace.Replace(num, x, y);
        }

        public override string ToString()
        {
            return mapSpace.ToString();
        }
    }
}
