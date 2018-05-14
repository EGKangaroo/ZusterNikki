namespace ZusterNikki
{
    partial class AdLibsResultScherm
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
            this.LBLStoryText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLStoryText
            // 
            this.LBLStoryText.AutoSize = true;
            this.LBLStoryText.Location = new System.Drawing.Point(318, 179);
            this.LBLStoryText.Name = "LBLStoryText";
            this.LBLStoryText.Size = new System.Drawing.Size(41, 17);
            this.LBLStoryText.TabIndex = 0;
            this.LBLStoryText.Text = "Story";
            // 
            // AdLibsResultScherm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.LBLStoryText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdLibsResultScherm";
            this.Text = "AdLibsResultScherm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdLibsResultScherm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLStoryText;
    }
}