namespace GrumpMapEditor
{
    partial class EncounterEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptorTagSelector = new System.Windows.Forms.ComboBox();
            this.outputConsole = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.displayEncounterReg = new System.Windows.Forms.Label();
            this.submitChangeButton = new System.Windows.Forms.Button();
            this.descriptorTagSelectorLabel = new System.Windows.Forms.Label();
            this.descriptorAdderButton = new System.Windows.Forms.Button();
            this.descriptorText = new System.Windows.Forms.TextBox();
            this.descriptorTextLabel = new System.Windows.Forms.Label();
            this.entityTypeSelector = new System.Windows.Forms.ComboBox();
            this.entityParameterEntry = new System.Windows.Forms.TextBox();
            this.entityAdderButton = new System.Windows.Forms.Button();
            this.entityTypeSelectorLabel = new System.Windows.Forms.Label();
            this.entityParameterText = new System.Windows.Forms.Label();
            this.storedValuesDisplayBox = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptorTagSelector
            // 
            this.descriptorTagSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descriptorTagSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.descriptorTagSelector.FormattingEnabled = true;
            this.descriptorTagSelector.Location = new System.Drawing.Point(9, 283);
            this.descriptorTagSelector.Name = "descriptorTagSelector";
            this.descriptorTagSelector.Size = new System.Drawing.Size(121, 21);
            this.descriptorTagSelector.TabIndex = 0;
            this.descriptorTagSelector.SelectionChangeCommitted += new System.EventHandler(this.TagSelector_OnSelect);
            // 
            // outputConsole
            // 
            this.outputConsole.Cursor = System.Windows.Forms.Cursors.No;
            this.outputConsole.Location = new System.Drawing.Point(3, 19);
            this.outputConsole.Multiline = true;
            this.outputConsole.Name = "outputConsole";
            this.outputConsole.ReadOnly = true;
            this.outputConsole.Size = new System.Drawing.Size(308, 180);
            this.outputConsole.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(3, 3);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(80, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output Console";
            // 
            // displayEncounterReg
            // 
            this.displayEncounterReg.AutoSize = true;
            this.displayEncounterReg.Location = new System.Drawing.Point(314, 3);
            this.displayEncounterReg.Name = "displayEncounterReg";
            this.displayEncounterReg.Size = new System.Drawing.Size(152, 13);
            this.displayEncounterReg.TabIndex = 4;
            this.displayEncounterReg.Text = "Encounter Type Stored Values";
            this.displayEncounterReg.Click += new System.EventHandler(this.displayEncounterReg_Click);
            // 
            // submitChangeButton
            // 
            this.submitChangeButton.Location = new System.Drawing.Point(3, 204);
            this.submitChangeButton.Name = "submitChangeButton";
            this.submitChangeButton.Size = new System.Drawing.Size(308, 41);
            this.submitChangeButton.TabIndex = 5;
            this.submitChangeButton.Text = "Save and Exit";
            this.submitChangeButton.UseVisualStyleBackColor = true;
            this.submitChangeButton.Click += new System.EventHandler(this.SaveButton_OnClick);
            // 
            // descriptorTagSelectorLabel
            // 
            this.descriptorTagSelectorLabel.AutoSize = true;
            this.descriptorTagSelectorLabel.Location = new System.Drawing.Point(6, 251);
            this.descriptorTagSelectorLabel.Name = "descriptorTagSelectorLabel";
            this.descriptorTagSelectorLabel.Size = new System.Drawing.Size(77, 13);
            this.descriptorTagSelectorLabel.TabIndex = 6;
            this.descriptorTagSelectorLabel.Text = "Descriptor Tag";
            // 
            // descriptorAdderButton
            // 
            this.descriptorAdderButton.Enabled = false;
            this.descriptorAdderButton.Location = new System.Drawing.Point(513, 309);
            this.descriptorAdderButton.Name = "descriptorAdderButton";
            this.descriptorAdderButton.Size = new System.Drawing.Size(121, 23);
            this.descriptorAdderButton.TabIndex = 7;
            this.descriptorAdderButton.Text = "Add Descriptor";
            this.descriptorAdderButton.UseVisualStyleBackColor = true;
            this.descriptorAdderButton.Click += new System.EventHandler(this.DescriptorAdder_OnClick);
            // 
            // descriptorText
            // 
            this.descriptorText.Location = new System.Drawing.Point(173, 283);
            this.descriptorText.Name = "descriptorText";
            this.descriptorText.Size = new System.Drawing.Size(461, 20);
            this.descriptorText.TabIndex = 8;
            this.descriptorText.TextChanged += new System.EventHandler(this.DescriptorText_TextChanged);
            // 
            // descriptorTextLabel
            // 
            this.descriptorTextLabel.AutoSize = true;
            this.descriptorTextLabel.Location = new System.Drawing.Point(170, 251);
            this.descriptorTextLabel.Margin = new System.Windows.Forms.Padding(3);
            this.descriptorTextLabel.Name = "descriptorTextLabel";
            this.descriptorTextLabel.Size = new System.Drawing.Size(79, 13);
            this.descriptorTextLabel.TabIndex = 10;
            this.descriptorTextLabel.Text = "Descriptor Text";
            // 
            // entityTypeSelector
            // 
            this.entityTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entityTypeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entityTypeSelector.FormattingEnabled = true;
            this.entityTypeSelector.Location = new System.Drawing.Point(9, 383);
            this.entityTypeSelector.Name = "entityTypeSelector";
            this.entityTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.entityTypeSelector.TabIndex = 11;
            // 
            // entityParameterEntry
            // 
            this.entityParameterEntry.Location = new System.Drawing.Point(173, 383);
            this.entityParameterEntry.Name = "entityParameterEntry";
            this.entityParameterEntry.Size = new System.Drawing.Size(461, 20);
            this.entityParameterEntry.TabIndex = 12;
            this.entityParameterEntry.Text = "Temp text box (will be replaced with the final parameters after the baseline enti" +
    "ties are done)";
            // 
            // entityAdderButton
            // 
            this.entityAdderButton.Enabled = false;
            this.entityAdderButton.Location = new System.Drawing.Point(513, 407);
            this.entityAdderButton.Name = "entityAdderButton";
            this.entityAdderButton.Size = new System.Drawing.Size(121, 23);
            this.entityAdderButton.TabIndex = 13;
            this.entityAdderButton.Text = "Add Entity";
            this.entityAdderButton.UseVisualStyleBackColor = true;
            // 
            // entityTypeSelectorLabel
            // 
            this.entityTypeSelectorLabel.AutoSize = true;
            this.entityTypeSelectorLabel.Location = new System.Drawing.Point(6, 353);
            this.entityTypeSelectorLabel.Name = "entityTypeSelectorLabel";
            this.entityTypeSelectorLabel.Size = new System.Drawing.Size(60, 13);
            this.entityTypeSelectorLabel.TabIndex = 14;
            this.entityTypeSelectorLabel.Text = "Entity Type";
            // 
            // entityParameterText
            // 
            this.entityParameterText.AutoSize = true;
            this.entityParameterText.Location = new System.Drawing.Point(170, 353);
            this.entityParameterText.Name = "entityParameterText";
            this.entityParameterText.Size = new System.Drawing.Size(89, 13);
            this.entityParameterText.TabIndex = 15;
            this.entityParameterText.Text = "Entity Parameters";
            // 
            // storedValuesDisplayBox
            // 
            this.storedValuesDisplayBox.Location = new System.Drawing.Point(317, 19);
            this.storedValuesDisplayBox.Name = "storedValuesDisplayBox";
            this.storedValuesDisplayBox.Size = new System.Drawing.Size(317, 180);
            this.storedValuesDisplayBox.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 457);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.outputConsole);
            this.tabPage1.Controls.Add(this.submitChangeButton);
            this.tabPage1.Controls.Add(this.entityAdderButton);
            this.tabPage1.Controls.Add(this.storedValuesDisplayBox);
            this.tabPage1.Controls.Add(this.descriptorAdderButton);
            this.tabPage1.Controls.Add(this.outputLabel);
            this.tabPage1.Controls.Add(this.displayEncounterReg);
            this.tabPage1.Controls.Add(this.descriptorTagSelectorLabel);
            this.tabPage1.Controls.Add(this.entityParameterText);
            this.tabPage1.Controls.Add(this.entityParameterEntry);
            this.tabPage1.Controls.Add(this.descriptorTagSelector);
            this.tabPage1.Controls.Add(this.entityTypeSelectorLabel);
            this.tabPage1.Controls.Add(this.descriptorTextLabel);
            this.tabPage1.Controls.Add(this.entityTypeSelector);
            this.tabPage1.Controls.Add(this.descriptorText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EncounterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(669, 481);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EncounterEditor";
            this.Text = "Encounter Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EncounterEditor_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox descriptorTagSelector;
        private System.Windows.Forms.TextBox outputConsole;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label displayEncounterReg;
        private System.Windows.Forms.Button submitChangeButton;
        private System.Windows.Forms.Label descriptorTagSelectorLabel;
        private System.Windows.Forms.Button descriptorAdderButton;
        private System.Windows.Forms.TextBox descriptorText;
        private System.Windows.Forms.Label descriptorTextLabel;
        private System.Windows.Forms.ComboBox entityTypeSelector;
        private System.Windows.Forms.TextBox entityParameterEntry;
        private System.Windows.Forms.Button entityAdderButton;
        private System.Windows.Forms.Label entityTypeSelectorLabel;
        private System.Windows.Forms.Label entityParameterText;
        private System.Windows.Forms.TreeView storedValuesDisplayBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}