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

            for(int i = 0; i < buttonGrid.ButtonGrid.GetLength(0); i++)
            {
                for(int j = 0; j < buttonGrid.ButtonGrid.GetLength(1); j++)
                {
                    Button temp = buttonGrid.GetButton(i, j).Button;
                    mapButtonAccessGrid.Controls.Add(temp, i, j);
                    temp.Width = mapButtonAccessGrid.GetColumnWidths()[j];
                    temp.Height = mapButtonAccessGrid.GetRowHeights()[i];
                }
            }
        }

        private void RemoveColButton_OnClick(object sender, EventArgs e)
        {
            if (mapButtonAccessGrid.ColumnCount > 1 && buttonGrid.RemoveCol())
            {
                outputTextBox.AppendText("Removing a column (data will be lost)...");
                outputTextBox.AppendText(Environment.NewLine);
                mapButtonAccessGrid.ColumnCount--;
                for(int i = 0; i < mapButtonAccessGrid.RowCount; i++)
                {
                    for(int j = 0; j < mapButtonAccessGrid.ColumnCount; j++)
                    {
                        Button temp = buttonGrid.GetButton(i, j).Button;
                        temp.Height = mapButtonAccessGrid.GetRowHeights()[i];
                        temp.Width = mapButtonAccessGrid.GetColumnWidths()[mapButtonAccessGrid.ColumnCount - 1];
                    }
                }
                mapButtonAccessGrid.Refresh();
                return;
            }
            outputTextBox.AppendText("Failed to remove a column (likely tried to remove all columns)");
            outputTextBox.AppendText(Environment.NewLine);
        }


        private void RemoveRowButton_OnClick(object sender, EventArgs e)
        {
            if (mapButtonAccessGrid.RowCount > 1 && buttonGrid.RemoveRow())
            {
                outputTextBox.AppendText("Removing a row (data will be lost)...");
                outputTextBox.AppendText(Environment.NewLine);
                mapButtonAccessGrid.RowCount--;
                for (int i = 0; i < mapButtonAccessGrid.RowCount; i++)
                {
                    for(int j = 0; j < mapButtonAccessGrid.ColumnCount; j++)
                    {
                        Button temp = buttonGrid.GetButton(i, j).Button;
                        temp.Height = mapButtonAccessGrid.GetRowHeights()[mapButtonAccessGrid.RowCount - 1];
                        temp.Width = mapButtonAccessGrid.GetColumnWidths()[i];
                    }
                }
                mapButtonAccessGrid.Refresh();
                return;
            }
            outputTextBox.AppendText("Failed to remove a row (likely tried to remove all rows)");
            outputTextBox.AppendText(Environment.NewLine);
        }

        private void AddRowButton_OnClick(object sender, EventArgs e)
        {
            if (buttonGrid.AddRow())
            {
                outputTextBox.AppendText("Adding a new row...");
                outputTextBox.AppendText(Environment.NewLine);
                RowStyle temp = mapButtonAccessGrid.RowStyles[mapButtonAccessGrid.RowCount - 1];
                mapButtonAccessGrid.RowCount++;
                mapButtonAccessGrid.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                AddNewRowControls();
                mapButtonAccessGrid.Refresh();
                return;
            }
            outputTextBox.AppendText("Failed to add a new row...");
            outputTextBox.AppendText(Environment.NewLine);            
        }

        private void AddColumnButton_OnClick(object sender, EventArgs e)
        {
            if (buttonGrid.AddCol())
            {
                outputTextBox.AppendText("Adding a new column...");
                outputTextBox.AppendText(Environment.NewLine);
                ColumnStyle temp = mapButtonAccessGrid.ColumnStyles[mapButtonAccessGrid.ColumnCount - 1];
                mapButtonAccessGrid.ColumnCount++;
                mapButtonAccessGrid.ColumnStyles.Add(new ColumnStyle(temp.SizeType, temp.Width));
                AddNewColControls();
                mapButtonAccessGrid.Refresh();
                return;
            }
            outputTextBox.AppendText("Failed to add a new column...");
            outputTextBox.AppendText(Environment.NewLine);
        }

        private void AddNewRowControls()
        {
            for(int i = 0; i < mapButtonAccessGrid.ColumnCount; i++)
            {
                Button temp = buttonGrid.GetButton(mapButtonAccessGrid.RowCount - 1, i).Button;
                mapButtonAccessGrid.Controls.Add(temp, mapButtonAccessGrid.RowCount - 1, i);
                temp.Height = mapButtonAccessGrid.GetRowHeights()[mapButtonAccessGrid.RowCount - 1];
                temp.Width = mapButtonAccessGrid.GetColumnWidths()[i];
            }
        }

        private void AddNewColControls()
        {
            for (int i = 0; i < mapButtonAccessGrid.RowCount; i++)
            {
                Button temp = buttonGrid.GetButton(i, mapButtonAccessGrid.ColumnCount - 1).Button;
                mapButtonAccessGrid.Controls.Add(temp, i, mapButtonAccessGrid.ColumnCount - 1);
                temp.Height = mapButtonAccessGrid.GetRowHeights()[i];
                temp.Width = mapButtonAccessGrid.GetColumnWidths()[mapButtonAccessGrid.ColumnCount - 1];
            }
        }
    }
}
