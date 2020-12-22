using System;
using System.IO;
using System.Reflection;
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
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "GrumpMap File|*.gmf";
            //saveFileDialog1.Title = "Save a Map File";
            //saveFileDialog1.ShowDialog();
            //StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
            ////Loop the button grid here and add it to the text file
            //MethodInfo[] methodInfos = typeof(TopLevelUI).GetMethods(BindingFlags.Public | BindingFlags.Static);
            //// sort methods by name
            ////Array.Sort(methodInfos, delegate (MethodInfo methodInfo1, MethodInfo methodInfo2)
            ////   { 
            ////       return methodInfo1.Name.CompareTo(methodInfo2.Name); 
            ////   });

            //// write method names
            //foreach (MethodInfo methodInfo in methodInfos)
            //{
            //    outputTextBox.AppendText(methodInfo.Name);
            //    writer.WriteLine(methodInfo.Name);
            //}
            //writer.Dispose();
            //writer.Close();
            edit.WriteToSystem();
        }

        private void TopLevelUI_OnEnter(object sender, EventArgs e)
        {
            if(buttonGrid != null)
            {
                edit.RefreshDataSet(buttonGrid);
            }
        }
    }
}
