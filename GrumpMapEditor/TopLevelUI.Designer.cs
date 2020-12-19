
namespace GrumpMapEditor
{
    partial class TopLevelUI
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
            this.addRowButton = new System.Windows.Forms.Button();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.addColButton = new System.Windows.Forms.Button();
            this.removeColButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(471, 12);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(75, 75);
            this.addRowButton.TabIndex = 1;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.AddRowButton_OnClick);
            // 
            // removeRowButton
            // 
            this.removeRowButton.Location = new System.Drawing.Point(552, 12);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(75, 75);
            this.removeRowButton.TabIndex = 2;
            this.removeRowButton.Text = "Remove Row";
            this.removeRowButton.UseVisualStyleBackColor = true;
            this.removeRowButton.Click += new System.EventHandler(this.RemoveRowButton_OnClick);
            // 
            // addColButton
            // 
            this.addColButton.Location = new System.Drawing.Point(633, 12);
            this.addColButton.Name = "addColButton";
            this.addColButton.Size = new System.Drawing.Size(75, 75);
            this.addColButton.TabIndex = 3;
            this.addColButton.Text = "Add Column";
            this.addColButton.UseVisualStyleBackColor = true;
            this.addColButton.Click += new System.EventHandler(this.AddColumnButton_OnClick);
            // 
            // removeColButton
            // 
            this.removeColButton.Location = new System.Drawing.Point(714, 12);
            this.removeColButton.Name = "removeColButton";
            this.removeColButton.Size = new System.Drawing.Size(75, 75);
            this.removeColButton.TabIndex = 4;
            this.removeColButton.Text = "Remove Column";
            this.removeColButton.UseVisualStyleBackColor = true;
            this.removeColButton.Click += new System.EventHandler(this.RemoveColButton_OnClick);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(471, 93);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(318, 76);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "Save/Export Map";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.outputTextBox.Location = new System.Drawing.Point(471, 175);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(318, 263);
            this.outputTextBox.TabIndex = 6;
            // 
            // TopLevelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.removeColButton);
            this.Controls.Add(this.addColButton);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.addRowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopLevelUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Grump Map Creation Tool";
            this.Shown += new System.EventHandler(this.TopLevelUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button removeRowButton;
        private System.Windows.Forms.Button addColButton;
        private System.Windows.Forms.Button removeColButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

