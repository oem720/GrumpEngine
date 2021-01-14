using System;
using System.Windows.Forms;
using GrumpEngine;

namespace GrumpMapEditor
{
    public partial class EncounterEditor : Form
    {
#pragma warning disable IDE0044 // Add readonly modifier
        Tile internEncounterType;
#pragma warning restore IDE0044 // Add readonly modifier
        Tag tempTag;
        string tempDesc;

#pragma warning disable IDE0044 // Add readonly modifier
        EncounterSelectionButton _esb;
#pragma warning restore IDE0044 // Add readonly modifier

        public EncounterEditor(EncounterSelectionButton esb)
        {
            internEncounterType = esb.EditedTile;
            _esb = esb;
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            foreach(var item in Enum.GetValues(typeof(Tag)))
            {
                descriptorTagSelector.Items.Add(item);
            }            
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

        private void ValueDisplayButton_OnClick(object sender, EventArgs e)
        {
            storedValuesDisplayBox.Text = "";

            storedValuesDisplayBox.AppendText($"Current Outward value -- {internEncounterType.OutwardValue}");
            storedValuesDisplayBox.AppendText(Environment.NewLine);

            foreach(DescriptorString ds in internEncounterType.Descriptors)
            {
                storedValuesDisplayBox.AppendText($"{ds.Tag} -- {ds.Descriptor}");
                storedValuesDisplayBox.AppendText(Environment.NewLine);
            }

            foreach(Entity ent in internEncounterType.EntityRegistry)
            {
                storedValuesDisplayBox.AppendText($"{ent}");
                storedValuesDisplayBox.AppendText(Environment.NewLine);
            }
        }

        private void TagSelector_OnSelect(object sender, EventArgs e)
        {
            tempTag = (Tag)descriptorTagSelector.SelectedItem;
            if (tempDesc != null)
            {
                descriptorAdderButton.Enabled = true;
            }
        }

        private void DescriptorText_TextChanged(object sender, EventArgs e)
        {
            tempDesc = descriptorText.Text;
            if (tempTag != 0)
            {
                descriptorAdderButton.Enabled = true;
            }
        }

        private void DescriptorAdder_OnClick(object sender, EventArgs e)
        {
            outputConsole.AppendText("Adding descriptor...");
            outputConsole.AppendText(Environment.NewLine);
            if (tempDesc != null && tempTag != 0)
            {
                internEncounterType.AddDescriptorString(new DescriptorString(tempDesc, tempTag));
                outputConsole.AppendText("Descriptor adding successful!");
                outputConsole.AppendText(Environment.NewLine);
                return;
            }
            outputConsole.AppendText("Failed to add descriptor!");
            outputConsole.AppendText(Environment.NewLine);
        }

        private void SaveButton_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void EditorClosing(object sender, ReturnedTileValueEventArgs e)
        {
            e.EditedTile = internEncounterType;
        }

        private void EncounterEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            _esb.EncounterEditor_Closing(sender, e);
        }
    }
}
