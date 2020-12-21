using System;
using System.Windows.Forms;
using System.Drawing;
using GrumpEngine;

namespace GrumpMapEditor
{
    public partial class EncounterEditor : Form
    {
        Tile internEncounterType;

        public EncounterEditor(ref Tile et, )
        {
            internEncounterType = et;
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            this.Name = $"Encounter Editor - [{}, {}]";
            foreach(var item in Enum.GetValues(typeof(Tag)))
            {
                descriptorTagSelector.Items.Add(item);
            }
            descriptorTagSelector.Width = FindGreatestLength(descriptorTagSelector);
            descriptorTagSelector.DropDownWidth = FindGreatestLength(descriptorTagSelector);
        }

        private int FindGreatestLength(object sender)
        {
            int newWidth = (int)descriptorTagSelector.CreateGraphics().MeasureString(((ComboBox)sender).Items[0].ToString(), descriptorTagSelector.Font).Width;
            foreach (Tag s in ((ComboBox)sender).Items)
            {
                if (newWidth < (int)descriptorTagSelector.CreateGraphics().MeasureString(s.ToString(), descriptorTagSelector.Font).Width)
                {
                    newWidth = (int)descriptorTagSelector.CreateGraphics().MeasureString(s.ToString(), descriptorTagSelector.Font).Width;
                }
            }
            return newWidth;
        }
    }
}
