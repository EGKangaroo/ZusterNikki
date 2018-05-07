namespace ZusterNikki
{
    partial class Quiz
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
            this.QuizTitelLabel = new System.Windows.Forms.Label();
            this.UitlegQuizBtn = new System.Windows.Forms.Button();
            this.StartQuizBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuizTitelLabel
            // 
            this.QuizTitelLabel.AutoSize = true;
            this.QuizTitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizTitelLabel.Location = new System.Drawing.Point(304, 103);
            this.QuizTitelLabel.Name = "QuizTitelLabel";
            this.QuizTitelLabel.Size = new System.Drawing.Size(122, 55);
            this.QuizTitelLabel.TabIndex = 0;
            this.QuizTitelLabel.Text = "Quiz";
            // 
            // UitlegQuizBtn
            // 
            this.UitlegQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UitlegQuizBtn.Location = new System.Drawing.Point(267, 250);
            this.UitlegQuizBtn.Name = "UitlegQuizBtn";
            this.UitlegQuizBtn.Size = new System.Drawing.Size(200, 80);
            this.UitlegQuizBtn.TabIndex = 1;
            this.UitlegQuizBtn.Text = "Uitleg";
            this.UitlegQuizBtn.UseVisualStyleBackColor = true;
            // 
            // StartQuizBtn
            // 
            this.StartQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartQuizBtn.Location = new System.Drawing.Point(267, 356);
            this.StartQuizBtn.Name = "StartQuizBtn";
            this.StartQuizBtn.Size = new System.Drawing.Size(200, 80);
            this.StartQuizBtn.TabIndex = 2;
            this.StartQuizBtn.Text = "Start";
            this.StartQuizBtn.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.StartQuizBtn);
            this.Controls.Add(this.UitlegQuizBtn);
            this.Controls.Add(this.QuizTitelLabel);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizTitelLabel;
        private System.Windows.Forms.Button UitlegQuizBtn;
        private System.Windows.Forms.Button StartQuizBtn;
    }
}