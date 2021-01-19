using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrumpMapEditor
{
    public partial class TopLevelUI : Form
    {
        MapSpaceEditor edit = new MapSpaceEditor();
        Grid buttonGrid;

        public TopLevelUI()
        {
            InitializeComponent();
        }

        private void TopLevelUI_Load(object sender, EventArgs e)
        {
            buttonGrid = new Grid(edit.Map, new Point(12, 12), 452, 426, 5, 5);
            ReAddControls();
        }

        private void RemoveColButton_OnClick(object sender, EventArgs e)
        {
            if (buttonGrid.GetLength(1) > 1)
            {
                outputTextBox.AppendText("Removing a column (data will be lost)...");
                outputTextBox.AppendText(Environment.NewLine);
                RemoveControls();
                buttonGrid.RemoveCol();
                ReAddControls();
                return;
            }
            outputTextBox.AppendText("Failed to remove a column (cannot remove the last column)...");
            outputTextBox.AppendText(Environment.NewLine);
        }


        private void RemoveRowButton_OnClick(object sender, EventArgs e)
        {
            if (buttonGrid.GetLength(0) > 1)
            {
                outputTextBox.AppendText("Removing a row (data will be lost)...");
                outputTextBox.AppendText(Environment.NewLine);
                RemoveControls();
                buttonGrid.RemoveRow();
                ReAddControls();
                return;
            }
            outputTextBox.AppendText("Failed to remove a row (cannot remove the last row)...");
            outputTextBox.AppendText(Environment.NewLine);
        }

        private void AddRowButton_OnClick(object sender, EventArgs e)
        {
            outputTextBox.AppendText("Adding a row...");
            outputTextBox.AppendText(Environment.NewLine);
            buttonGrid.AddRow();
            ReAddControls();            
        }

        private void AddColumnButton_OnClick(object sender, EventArgs e)
        {
            outputTextBox.AppendText("Adding a column...");
            outputTextBox.AppendText(Environment.NewLine);
            buttonGrid.AddCol();
            ReAddControls();
        }

        private void ReAddControls()
        {
            for (int i = 0; i < buttonGrid.GetLength(0); i++)
            {
                for (int j = 0; j < buttonGrid.GetLength(1); j++)
                {
                    this.Controls.Add(buttonGrid.GetButton(i, j).Button);
                }
            }
        }

        private void RemoveControls()
        {
            for(int i = 0; i < buttonGrid.GetLength(0); i++)
            {
                for(int j = 0; j < buttonGrid.GetLength(1); j++)
                {
                    this.Controls.Remove(buttonGrid.GetButton(i, j).Button);
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Grump Map File|*.GRUMP";
            saveFileDialog1.Title = "Save a Grump Map File";
            saveFileDialog1.ShowDialog();
            edit.WriteToSystem(saveFileDialog1.FileName);
        }

        private void TopLevelUI_OnEnter(object sender, EventArgs e)
        {
            if(buttonGrid != null)
            {
                edit.RefreshDataSet(buttonGrid);
            }
        }

        private void TopLevelUI_Load_1(object sender, EventArgs e)
        {

        }
    }
}
