using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrumpEngine;
using System.Drawing;

namespace GrumpMapEditor
{
    class Grid
    {
        const int SPACING_VALUE = 6;

        readonly ResizeableMatrix<EncounterSelectionButton> grid;
        readonly MapSpaceDefinition mMap;
        Point loc;
        readonly int length, height;

        public Grid(MapSpaceDefinition map, Point startLoc, int length, int height, int numRows, int numCols)  
        {
            grid = new ResizeableMatrix<EncounterSelectionButton>(numRows, numCols);
            mMap = map;
            loc = startLoc;
            this.length = length;
            this.height = height;
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
            CreateButtonSizesAndCoordinates();
        }

        private void InitNewCol()
        {
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                grid.Add(new EncounterSelectionButton(mMap.GetTileValue(i, grid.GetLength(1) - 1)));
            }
            CreateButtonSizesAndCoordinates();
        }

        private void InitNewRow()
        {
            for (int i = 0; i < grid.GetLength(1); i++)
            {
                grid.Add(new EncounterSelectionButton(mMap.GetTileValue(grid.GetLength(0) - 1, i)));
            }
            CreateButtonSizesAndCoordinates();
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
            CreateButtonSizesAndCoordinates();
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
            CreateButtonSizesAndCoordinates();
            return true;
        }

        public int GetLength(int dimension)
        {
            return grid.GetLength(dimension);
        }

        public void CreateButtonSizesAndCoordinates()
        {
            int buttonWidth = (length - (SPACING_VALUE * (grid.GetLength(1) - 1))) / grid.GetLength(1);
            int buttonHeight = (height - (SPACING_VALUE * (grid.GetLength(0) - 1))) / grid.GetLength(0);

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid.GetValue(i, j).Button.Width = buttonWidth;
                    grid.GetValue(i, j).Button.Height = buttonHeight;
                    grid.GetValue(i, j).Button.Location = new Point(loc.X + (j * SPACING_VALUE) + (j * buttonWidth),
                        loc.Y + (i * SPACING_VALUE) + (i * buttonHeight));
                }
            }
        }
    }
}
