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
            this.SuspendLayout();
            // 
            // descriptorTagSelector
            // 
            this.descriptorTagSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descriptorTagSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.descriptorTagSelector.FormattingEnabled = true;
            this.descriptorTagSelector.Location = new System.Drawing.Point(12, 12);
            this.descriptorTagSelector.Name = "descriptorTagSelector";
            this.descriptorTagSelector.Size = new System.Drawing.Size(121, 21);
            this.descriptorTagSelector.TabIndex = 0;
            // 
            // EncounterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(469, 281);
            this.Controls.Add(this.descriptorTagSelector);
            this.Name = "EncounterEditor";
            this.Text = "Encounter Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox descriptorTagSelector;
    }
}