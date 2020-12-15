﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrumpMapEditor
{
    public partial class TopLevelUI : Form
    {
        MapSpaceEditor edit = new MapSpaceEditor();

        public TopLevelUI()
        {
            InitializeComponent();
        }

        private void TopLevelUI_Load(object sender, EventArgs e)
        {            
            edit.WriteToSystem();
        }
    }
}
