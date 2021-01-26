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
            this.storedValuesDisplayBox = new System.Windows.Forms.TextBox();
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
            this.Properties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptorTagSelector
            // 
            this.descriptorTagSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descriptorTagSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.descriptorTagSelector.FormattingEnabled = true;
            this.descriptorTagSelector.Location = new System.Drawing.Point(12, 324);
            this.descriptorTagSelector.Name = "descriptorTagSelector";
            this.descriptorTagSelector.Size = new System.Drawing.Size(121, 21);
            this.descriptorTagSelector.TabIndex = 0;
            this.descriptorTagSelector.SelectionChangeCommitted += new System.EventHandler(this.TagSelector_OnSelect);
            // 
            // outputConsole
            // 
            this.outputConsole.Cursor = System.Windows.Forms.Cursors.No;
            this.outputConsole.Location = new System.Drawing.Point(9, 27);
            this.outputConsole.Multiline = true;
            this.outputConsole.Name = "outputConsole";
            this.outputConsole.ReadOnly = true;
            this.outputConsole.Size = new System.Drawing.Size(320, 219);
            this.outputConsole.TabIndex = 1;
            // 
            // storedValuesDisplayBox
            // 
            this.storedValuesDisplayBox.Cursor = System.Windows.Forms.Cursors.No;
            this.storedValuesDisplayBox.Location = new System.Drawing.Point(338, 27);
            this.storedValuesDisplayBox.Multiline = true;
            this.storedValuesDisplayBox.Name = "storedValuesDisplayBox";
            this.storedValuesDisplayBox.ReadOnly = true;
            this.storedValuesDisplayBox.Size = new System.Drawing.Size(319, 219);
            this.storedValuesDisplayBox.TabIndex = 2;
            this.storedValuesDisplayBox.TextChanged += new System.EventHandler(this.storedValuesDisplayBox_TextChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(10, 7);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(80, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output Console";
            // 
            // displayEncounterReg
            // 
            this.displayEncounterReg.AutoSize = true;
            this.displayEncounterReg.Location = new System.Drawing.Point(335, 7);
            this.displayEncounterReg.Name = "displayEncounterReg";
            this.displayEncounterReg.Size = new System.Drawing.Size(152, 13);
            this.displayEncounterReg.TabIndex = 4;
            this.displayEncounterReg.Text = "Encounter Type Stored Values";
            // 
            // submitChangeButton
            // 
            this.submitChangeButton.Location = new System.Drawing.Point(9, 252);
            this.submitChangeButton.Name = "submitChangeButton";
            this.submitChangeButton.Size = new System.Drawing.Size(320, 41);
            this.submitChangeButton.TabIndex = 5;
            this.submitChangeButton.Text = "Save and Exit";
            this.submitChangeButton.UseVisualStyleBackColor = true;
            this.submitChangeButton.Click += new System.EventHandler(this.SaveButton_OnClick);
            // 
            // descriptorTagSelectorLabel
            // 
            this.descriptorTagSelectorLabel.AutoSize = true;
            this.descriptorTagSelectorLabel.Location = new System.Drawing.Point(9, 306);
            this.descriptorTagSelectorLabel.Name = "descriptorTagSelectorLabel";
            this.descriptorTagSelectorLabel.Size = new System.Drawing.Size(77, 13);
            this.descriptorTagSelectorLabel.TabIndex = 6;
            this.descriptorTagSelectorLabel.Text = "Descriptor Tag";
            // 
            // descriptorAdderButton
            // 
            this.descriptorAdderButton.Enabled = false;
            this.descriptorAdderButton.Location = new System.Drawing.Point(536, 351);
            this.descriptorAdderButton.Name = "descriptorAdderButton";
            this.descriptorAdderButton.Size = new System.Drawing.Size(121, 23);
            this.descriptorAdderButton.TabIndex = 7;
            this.descriptorAdderButton.Text = "Add Descriptor";
            this.descriptorAdderButton.UseVisualStyleBackColor = true;
            this.descriptorAdderButton.Click += new System.EventHandler(this.DescriptorAdder_OnClick);
            // 
            // descriptorText
            // 
            this.descriptorText.Location = new System.Drawing.Point(170, 325);
            this.descriptorText.Name = "descriptorText";
            this.descriptorText.Size = new System.Drawing.Size(487, 20);
            this.descriptorText.TabIndex = 8;
            this.descriptorText.TextChanged += new System.EventHandler(this.DescriptorText_TextChanged);
            // 
            // descriptorTextLabel
            // 
            this.descriptorTextLabel.AutoSize = true;
            this.descriptorTextLabel.Location = new System.Drawing.Point(167, 306);
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
            this.entityTypeSelector.Location = new System.Drawing.Point(12, 417);
            this.entityTypeSelector.Name = "entityTypeSelector";
            this.entityTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.entityTypeSelector.TabIndex = 11;
            // 
            // entityParameterEntry
            // 
            this.entityParameterEntry.Location = new System.Drawing.Point(170, 418);
            this.entityParameterEntry.Name = "entityParameterEntry";
            this.entityParameterEntry.Size = new System.Drawing.Size(487, 20);
            this.entityParameterEntry.TabIndex = 12;
            this.entityParameterEntry.Text = "Temp text box (will be replaced with the final parameters after the baseline enti" +
    "ties are done)";
            // 
            // entityAdderButton
            // 
            this.entityAdderButton.Enabled = false;
            this.entityAdderButton.Location = new System.Drawing.Point(536, 444);
            this.entityAdderButton.Name = "entityAdderButton";
            this.entityAdderButton.Size = new System.Drawing.Size(121, 23);
            this.entityAdderButton.TabIndex = 13;
            this.entityAdderButton.Text = "Add Entity";
            this.entityAdderButton.UseVisualStyleBackColor = true;
            // 
            // entityTypeSelectorLabel
            // 
            this.entityTypeSelectorLabel.AutoSize = true;
            this.entityTypeSelectorLabel.Location = new System.Drawing.Point(12, 398);
            this.entityTypeSelectorLabel.Name = "entityTypeSelectorLabel";
            this.entityTypeSelectorLabel.Size = new System.Drawing.Size(60, 13);
            this.entityTypeSelectorLabel.TabIndex = 14;
            this.entityTypeSelectorLabel.Text = "Entity Type";
            // 
            // entityParameterText
            // 
            this.entityParameterText.AutoSize = true;
            this.entityParameterText.Location = new System.Drawing.Point(170, 399);
            this.entityParameterText.Name = "entityParameterText";
            this.entityParameterText.Size = new System.Drawing.Size(89, 13);
            this.entityParameterText.TabIndex = 15;
            this.entityParameterText.Text = "Entity Parameters";
            // 
            // Properties
            // 
            this.Properties.Location = new System.Drawing.Point(338, 252);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(318, 40);
            this.Properties.TabIndex = 16;
            this.Properties.Text = "Properties";
            this.Properties.UseVisualStyleBackColor = true;
            // 
            // EncounterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(669, 481);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.entityParameterText);
            this.Controls.Add(this.entityTypeSelectorLabel);
            this.Controls.Add(this.entityAdderButton);
            this.Controls.Add(this.entityParameterEntry);
            this.Controls.Add(this.entityTypeSelector);
            this.Controls.Add(this.descriptorTextLabel);
            this.Controls.Add(this.descriptorText);
            this.Controls.Add(this.descriptorAdderButton);
            this.Controls.Add(this.descriptorTagSelectorLabel);
            this.Controls.Add(this.submitChangeButton);
            this.Controls.Add(this.displayEncounterReg);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.storedValuesDisplayBox);
            this.Controls.Add(this.outputConsole);
            this.Controls.Add(this.descriptorTagSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EncounterEditor";
            this.Text = "Encounter Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EncounterEditor_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox descriptorTagSelector;
        private System.Windows.Forms.TextBox outputConsole;
        private System.Windows.Forms.TextBox storedValuesDisplayBox;
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
        private System.Windows.Forms.Button Properties;
    }
}