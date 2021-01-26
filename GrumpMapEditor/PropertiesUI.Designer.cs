
namespace GrumpMapEditor
{
    partial class PropertiesUI
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
            this.playSpawnBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // playSpawnBox
            // 
            this.playSpawnBox.AutoSize = true;
            this.playSpawnBox.Location = new System.Drawing.Point(12, 12);
            this.playSpawnBox.Name = "playSpawnBox";
            this.playSpawnBox.Size = new System.Drawing.Size(96, 17);
            this.playSpawnBox.TabIndex = 0;
            this.playSpawnBox.Text = "Players Spawn";
            this.playSpawnBox.UseVisualStyleBackColor = true;
            // 
            // PropertiesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playSpawnBox);
            this.Name = "PropertiesUI";
            this.Text = "Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox playSpawnBox;
    }
}