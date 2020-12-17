using System;
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
            buttonGrid = new Grid(edit.Map);

            //for(int i = 0; i < buttonGrid.ButtonGrid.GetLength(0); i++)
            //{
            //    for(int j = 0; j < buttonGrid.ButtonGrid.GetLength(1); j++)
            //    {
            //        Button temp = buttonGrid.GetButton(i, j).Button;
            //        mapButtonAccessGrid.Controls.Add(temp, i, j);
            //        temp.Width = mapButtonAccessGrid.GetColumnWidths()[j];
            //        temp.Height = mapButtonAccessGrid.GetRowHeights()[i];
            //    }
            //}
        }

        private void RemoveColButton_OnClick(object sender, EventArgs e)
        {
            //if (mapButtonAccessGrid.ColumnCount > 1 && buttonGrid.RemoveCol())
            //{
            //    //mapButtonAccessGrid.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

            //    outputTextBox.AppendText("Removing a column (data will be lost)...");
            //    outputTextBox.AppendText(Environment.NewLine);

            //    for (int i = 0; i < mapButtonAccessGrid.RowCount; i++)
            //    {
            //        mapButtonAccessGrid.Controls.Remove(mapButtonAccessGrid.GetControlFromPosition(mapButtonAccessGrid.ColumnCount - 1, i));
            //    }

            //    mapButtonAccessGrid.ColumnCount--;                
            //    mapButtonAccessGrid.Refresh();
            //    return;
            //}
            //outputTextBox.AppendText("Failed to remove a column (likely tried to remove all columns)");
            //outputTextBox.AppendText(Environment.NewLine);
        }


        private void RemoveRowButton_OnClick(object sender, EventArgs e)
        {
            //if (mapButtonAccessGrid.RowCount > 1)
            //{
            //    //mapButtonAccessGrid.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            //    outputTextBox.AppendText("Removing a row (data will be lost)...");
            //    outputTextBox.AppendText(Environment.NewLine);
            //    for (int i = 0; i < buttonGrid.GetLength(1); i++)
            //    {
            //        mapButtonAccessGrid.Controls.Remove(mapButtonAccessGrid.GetControlFromPosition(i, mapButtonAccessGrid.RowCount - 1));
            //    }
            //    mapButtonAccessGrid.RowCount--;
                
            //    mapButtonAccessGrid.Refresh();
            //    return;
            //}
            //outputTextBox.AppendText("Failed to remove a row (likely tried to remove all rows)");
            //outputTextBox.AppendText(Environment.NewLine);
        }

        private void AddRowButton_OnClick(object sender, EventArgs e)
        {
            //if (buttonGrid.AddRow())
            //{
            //    //mapButtonAccessGrid.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            //    outputTextBox.AppendText("Adding a new row...");
            //    outputTextBox.AppendText(Environment.NewLine);
            //    outputTextBox.AppendText($"{buttonGrid.GetLength(0)}");
            //    RowStyle temp = mapButtonAccessGrid.RowStyles[mapButtonAccessGrid.RowCount - 1];
            //    mapButtonAccessGrid.RowCount++;
            //    mapButtonAccessGrid.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //    AddNewRowControls();
            //    outputTextBox.AppendText($"{buttonGrid.GetLength(0)}");
            //    mapButtonAccessGrid.Refresh();
            //    return;
            //}
            //outputTextBox.AppendText("Failed to add a new row...");
            //outputTextBox.AppendText(Environment.NewLine);            
        }

        private void AddColumnButton_OnClick(object sender, EventArgs e)
        {
            //if (buttonGrid.AddCol())
            //{
            //    //mapButtonAccessGrid.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            //    outputTextBox.AppendText("Adding a new column...");
            //    outputTextBox.AppendText(Environment.NewLine);
            //    outputTextBox.AppendText($"{buttonGrid.GetLength(1)}");
            //    ColumnStyle temp = mapButtonAccessGrid.ColumnStyles[mapButtonAccessGrid.ColumnCount - 1];
            //    mapButtonAccessGrid.ColumnCount++;
            //    mapButtonAccessGrid.ColumnStyles.Add(new ColumnStyle(temp.SizeType, temp.Width));
            //    AddNewColControls();
            //    outputTextBox.AppendText($"{buttonGrid.GetLength(1)}");
            //    mapButtonAccessGrid.Refresh();
            //    return;
            //}
            //outputTextBox.AppendText("Failed to add a new column...");
            //outputTextBox.AppendText(Environment.NewLine);
        }

        private void AddNewRowControls()
        {
            //for(int i = 0; i < mapButtonAccessGrid.ColumnCount; i++)
            //{
            //    Button temp = buttonGrid.GetButton(mapButtonAccessGrid.RowCount - 1, i).Button;
            //    mapButtonAccessGrid.Controls.Add(temp, mapButtonAccessGrid.RowCount - 1, i);
            //}
        }

        private void AddNewColControls()
        {
            //for (int i = 0; i < mapButtonAccessGrid.RowCount; i++)
            //{
            //    Button temp = buttonGrid.GetButton(i, mapButtonAccessGrid.ColumnCount - 1).Button;
            //    mapButtonAccessGrid.Controls.Add(temp, i, mapButtonAccessGrid.ColumnCount - 1);
            //}
        }
    }
}
