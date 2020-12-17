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
        ResizeableMatrix<Button> grid;
        TableLayoutPanel reference;

        public Grid(TableLayoutPanel reference)
        {
            grid = new ResizeableMatrix<Button>(5, 5);
            this.reference = reference;
            initButtons();
        }

        private void initButtons()
        {
            
        }
    }
}
