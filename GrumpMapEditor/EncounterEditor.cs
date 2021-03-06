﻿using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GrumpEngine;

namespace GrumpMapEditor
{
    public partial class EncounterEditor : Form
    {
        Tile internEncounterType;
        Tag _tag;
        string _desc;
        EncounterSelectionButton _esb;
        PropertiesUI property = new PropertiesUI();
        TreeNode descriptorStringNode = new TreeNode();

        public EncounterEditor(EncounterSelectionButton esb)
        {
            internEncounterType = esb.EditedTile;
            _esb = esb;
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            for (int i = 100; i <= 105; i++)
            {
                descriptorTagSelector.Items.Add((Tag)i);
            }
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(IEntity).IsAssignableFrom(p));
            foreach (Type newType in types)
                if (!newType.Equals(typeof(IEntity)) && !newType.Equals(typeof(ICharacter)))
                    entityTypeSelector.Items.Add(newType.Name);
            descriptorTagSelector.DropDownWidth = FindGreatestLength(descriptorTagSelector);
            entityTypeSelector.DropDownWidth = FindGreatestLength(entityTypeSelector);
            descriptorStringNode.Text = "Descriptor Strings";
            storedValuesDisplayBox.Nodes.Add(descriptorStringNode);
            for(int i = 0; i < internEncounterType.Descriptors.Count; i++)
            {
                AddToTreeNode(internEncounterType.RequestString(i));
            }
        }

        private int FindGreatestLength(object sender)
        {
            int newWidth = (int)descriptorTagSelector.CreateGraphics().MeasureString(((ComboBox)sender).Items[0].ToString(), descriptorTagSelector.Font).Width;
            foreach (var s in ((ComboBox)sender).Items)
            {
                if (newWidth < (int)descriptorTagSelector.CreateGraphics().MeasureString(s.ToString(), descriptorTagSelector.Font).Width)
                {
                    newWidth = (int)descriptorTagSelector.CreateGraphics().MeasureString(s.ToString(), descriptorTagSelector.Font).Width;
                }
            }
            return newWidth;
        }

        private void TagSelector_OnSelect(object sender, EventArgs e)
        {
            _tag = (Tag)descriptorTagSelector.SelectedItem;
            if (_desc != null)
            {
                descriptorAdderButton.Enabled = true;
            }
        }

        private void DescriptorText_TextChanged(object sender, EventArgs e)
        {
            _desc = descriptorText.Text;
            if (_tag != 0)
            {
                descriptorAdderButton.Enabled = true;
            }
        }

        private void DescriptorAdder_OnClick(object sender, EventArgs e)
        {
            outputConsole.AppendText("Adding descriptor...");
            outputConsole.AppendText(Environment.NewLine);
            if (_desc != null && _tag != 0)
            {
                internEncounterType.AddDescriptorString(new DescriptorString(_desc, _tag));
                outputConsole.AppendText("Descriptor adding successful!");
                outputConsole.AppendText(Environment.NewLine);
                storedValuesDisplayBox.Text = "";
                AddToTreeNode(new DescriptorString(_desc, _tag));
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

        private void storedValuesDisplayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PropertyButtonClick(object sender, EventArgs e)
        {
            property.Show();
        }

        public void AddToTreeNode(DescriptorString ds)
        {
            bool found = false;
            foreach (TreeNode node in descriptorStringNode.Nodes)
                if (node.Text.Equals(ds.Tag.ToString()))
                    found = true;
            if (!found)
            {
                TreeNode newTagNode = new TreeNode();
                newTagNode.Text = ds.Tag.ToString();
                descriptorStringNode.Nodes.Add(newTagNode);
            }
            TreeNode newNode = new TreeNode();
            newNode.Text = ds.Descriptor;
            foreach (TreeNode node in descriptorStringNode.Nodes)
                if (node.Text.Equals(ds.Tag.ToString()))
                    node.Nodes.Add(newNode);
            storedValuesDisplayBox.Update();
        }

        private void displayEncounterReg_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void descriptorTagSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public void AddToTreeNode(Object o)
        //{
        //    bool found = false;
        //    foreach (TreeNode node in descriptorStringNode.Nodes)
        //        if (node.Text.Equals(o.GetType()))
        //            found = true;
        //    if (!found)
        //    {
        //        TreeNode newTagNode = new TreeNode();
        //        newTagNode.Text = ds.Tag.ToString();
        //        descriptorStringNode.Nodes.Add(newTagNode);
        //    }
        //    TreeNode newNode = new TreeNode();
        //    newNode.Text = o;
        //    foreach (TreeNode node in descriptorStringNode.Nodes)
        //        if (node.Text.Equals(ds.Tag.ToString()))
        //            node.Nodes.Add(newNode);
        //    storedValuesDisplayBox.Update();

        //    PropertyInfo[] myPropertyInfo;
        //    myPropertyInfo = Type.GetType("System.Type").GetProperties();
        //    Console.WriteLine("Properties of System.Type are:");
        //    for (int i = 0; i < myPropertyInfo.Length; i++)
        //    {
        //        Console.WriteLine(myPropertyInfo[i].ToString());
        //    }
        //}
    }
}
