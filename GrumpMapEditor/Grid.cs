using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrumpEngine;

namespace GrumpMapEditor
{
    class Grid
    {
        ResizeableMatrix<EncounterSelectionButton> grid;
        MapSpaceDefinition mMap;

        public Grid(MapSpaceDefinition map)        {
            grid = new ResizeableMatrix<EncounterSelectionButton>(5, 5);
            mMap = map;
            InitButtons();
        }

        public ResizeableMatrix<EncounterSelectionButton> ButtonGrid
        {
            get { return grid; }
        }

        public EncounterSelectionButton GetButton(int x, int y)
        {
            return grid.GetValue(x, y);
        }

        private void InitButtons()
        {
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    grid.Add(new EncounterSelectionButton(mMap.GetTileValue(i, j)));
                }
            }
        }

        private void InitNewCol()
        {
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                grid.Add(new EncounterSelectionButton(mMap.GetTileValue(i, grid.GetLength(1) - 1)));
            }
        }

        private void InitNewRow()
        {
            for (int i = 0; i < grid.GetLength(1); i++)
            {
                grid.Add(new EncounterSelectionButton(mMap.GetTileValue(grid.GetLength(0) - 1, i)));
            }
        }

        public bool AddRow()
        {
            mMap.AddRow();
            grid.AddRow();
            InitNewRow();
            return true;
        }

        public bool RemoveRow()
        {
            mMap.RemoveRow();
            grid.RemoveRow();
            return true;
        }

        public bool AddCol()
        {
            mMap.AddColumn();
            grid.AddCol();
            InitNewCol();
            return true;
        }

        public bool RemoveCol()
        {
            mMap.RemoveCol();
            grid.RemoveCol();
            return true;
        }
    }
}
