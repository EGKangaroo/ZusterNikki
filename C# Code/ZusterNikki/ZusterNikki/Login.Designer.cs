namespace ZusterNikki
{
    partial class Login
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTNLogIn = new System.Windows.Forms.Button();
            this.BTNNewAccount = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTNLogIn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTNNewAccount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTNLogIn
            // 
            this.BTNLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNLogIn.Location = new System.Drawing.Point(267, 167);
            this.BTNLogIn.Name = "BTNLogIn";
            this.BTNLogIn.Size = new System.Drawing.Size(259, 76);
            this.BTNLogIn.TabIndex = 0;
            this.BTNLogIn.Text = "Inloggen";
            this.BTNLogIn.UseVisualStyleBackColor = true;
            this.BTNLogIn.Click += new System.EventHandler(this.BTNInloggen_Click);
            // 
            // BTNNewAccount
            // 
            this.BTNNewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNNewAccount.Location = new System.Drawing.Point(3, 167);
            this.BTNNewAccount.Name = "BTNNewAccount";
            this.BTNNewAccount.Size = new System.Drawing.Size(258, 76);
            this.BTNNewAccount.TabIndex = 1;
            this.BTNNewAccount.Text = "Nieuw Account";
            this.BTNNewAccount.UseVisualStyleBackColor = true;
            // 
            // TBPassword
            // 
            this.TBPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBPassword.Location = new System.Drawing.Point(267, 112);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(177, 22);
            this.TBPassword.TabIndex = 2;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // TBName
            // 
            this.TBName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBName.Location = new System.Drawing.Point(267, 30);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(177, 22);
            this.TBName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wachtwoord";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(529, 246);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTNLogIn;
        private System.Windows.Forms.Button BTNNewAccount;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

