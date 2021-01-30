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
            this.components = new System.ComponentModel.Container();
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
            this.entityParameterText = new System.Windows.Forms.Label();
            this.storedValuesDisplayBox = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.contextMenuStrip6.SuspendLayout();
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
            this.descriptorTagSelector.SelectedIndexChanged += new System.EventHandler(this.descriptorTagSelector_SelectedIndexChanged);
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
            this.entityTypeSelector.Location = new System.Drawing.Point(17, 28);
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
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.tabPage1.Controls.Add(this.descriptorTextLabel);
            this.tabPage1.Controls.Add(this.descriptorText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.entityTypeSelector);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Entities";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.checkedListBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(640, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Properties";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Entity:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "pop",
            "dsoai",
            "aworj",
            "afowj",
            "vao"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(640, 424);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Property";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Value";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 343);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // EncounterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.contextMenuStrip5.PerformLayout();
            this.contextMenuStrip6.ResumeLayout(false);
            this.contextMenuStrip6.PerformLayout();
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
        private System.Windows.Forms.Label entityParameterText;
        private System.Windows.Forms.TreeView storedValuesDisplayBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}