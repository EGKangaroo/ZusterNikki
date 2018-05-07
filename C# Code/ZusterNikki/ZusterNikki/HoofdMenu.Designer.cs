namespace ZusterNikki
{
    partial class HoofdMenu
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
            this.ZusterNikkiLabel = new System.Windows.Forms.Label();
            this.GalgjeBtn = new System.Windows.Forms.Button();
            this.QuizBtn = new System.Windows.Forms.Button();
            this.AdlibBtn = new System.Windows.Forms.Button();
            this.UitlogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZusterNikkiLabel
            // 
            this.ZusterNikkiLabel.AutoSize = true;
            this.ZusterNikkiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.ZusterNikkiLabel.Location = new System.Drawing.Point(248, 108);
=======
            this.ZusterNikkiLabel.Location = new System.Drawing.Point(575, 122);
            this.ZusterNikkiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 2d7f3671b1136ff81c010a0a11e1c22046efe4b5
            this.ZusterNikkiLabel.Name = "ZusterNikkiLabel";
            this.ZusterNikkiLabel.Size = new System.Drawing.Size(215, 42);
            this.ZusterNikkiLabel.TabIndex = 0;
            this.ZusterNikkiLabel.Text = "Zuster Nikki";
            this.ZusterNikkiLabel.Click += new System.EventHandler(this.ZusterNikkiLabel_Click);
            // 
            // GalgjeBtn
            // 
            this.GalgjeBtn.Location = new System.Drawing.Point(279, 304);
            this.GalgjeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GalgjeBtn.Name = "GalgjeBtn";
            this.GalgjeBtn.Size = new System.Drawing.Size(100, 28);
            this.GalgjeBtn.TabIndex = 1;
            this.GalgjeBtn.Text = "Galgje";
            this.GalgjeBtn.UseVisualStyleBackColor = true;
            this.GalgjeBtn.Click += new System.EventHandler(this.GalgjeBtn_Click);
            // 
            // QuizBtn
            // 
            this.QuizBtn.Location = new System.Drawing.Point(279, 340);
            this.QuizBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QuizBtn.Name = "QuizBtn";
            this.QuizBtn.Size = new System.Drawing.Size(100, 28);
            this.QuizBtn.TabIndex = 2;
            this.QuizBtn.Text = "Quiz";
            this.QuizBtn.UseVisualStyleBackColor = true;
            // 
            // AdlibBtn
            // 
            this.AdlibBtn.Location = new System.Drawing.Point(279, 375);
            this.AdlibBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AdlibBtn.Name = "AdlibBtn";
            this.AdlibBtn.Size = new System.Drawing.Size(100, 28);
            this.AdlibBtn.TabIndex = 3;
            this.AdlibBtn.Text = "Adlibs";
            this.AdlibBtn.UseVisualStyleBackColor = true;
            // 
            // UitlogBtn
            // 
            this.UitlogBtn.Location = new System.Drawing.Point(279, 411);
            this.UitlogBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UitlogBtn.Name = "UitlogBtn";
            this.UitlogBtn.Size = new System.Drawing.Size(100, 28);
            this.UitlogBtn.TabIndex = 4;
            this.UitlogBtn.Text = "Uitloggen";
            this.UitlogBtn.UseVisualStyleBackColor = true;
            this.UitlogBtn.Click += new System.EventHandler(this.UitlogBtn_Click);
            // 
            // HoofdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(784, 561);
=======
            this.ClientSize = new System.Drawing.Size(1500, 714);
>>>>>>> 2d7f3671b1136ff81c010a0a11e1c22046efe4b5
            this.Controls.Add(this.UitlogBtn);
            this.Controls.Add(this.AdlibBtn);
            this.Controls.Add(this.QuizBtn);
            this.Controls.Add(this.GalgjeBtn);
            this.Controls.Add(this.ZusterNikkiLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoofdMenu";
            this.Text = "HoofdMenu";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.HoofdMenu_Load);
=======
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoofdMenu_FormClosing);
>>>>>>> 2d7f3671b1136ff81c010a0a11e1c22046efe4b5
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ZusterNikkiLabel;
        private System.Windows.Forms.Button GalgjeBtn;
        private System.Windows.Forms.Button QuizBtn;
        private System.Windows.Forms.Button AdlibBtn;
        private System.Windows.Forms.Button UitlogBtn;
    }
}