namespace ZusterNikki
{
    partial class NieuwAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBConfirmPassword = new System.Windows.Forms.TextBox();
            this.TBPatientNumber = new System.Windows.Forms.TextBox();
            this.CBPatientID = new System.Windows.Forms.CheckBox();
            this.BTNNewAccount = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TBPatientNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TBConfirmPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBPatientID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BTNNewAccount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTNCancel, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patiëntnummer?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wachtwoord";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Voer patiëntnummer in";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bevestig Wachtwoord";
            // 
            // TBName
            // 
            this.TBName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBName.Location = new System.Drawing.Point(267, 9);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(177, 22);
            this.TBName.TabIndex = 10;
            // 
            // TBPassword
            // 
            this.TBPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBPassword.Location = new System.Drawing.Point(267, 50);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(177, 22);
            this.TBPassword.TabIndex = 11;
            // 
            // TBConfirmPassword
            // 
            this.TBConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBConfirmPassword.Location = new System.Drawing.Point(267, 91);
            this.TBConfirmPassword.Name = "TBConfirmPassword";
            this.TBConfirmPassword.Size = new System.Drawing.Size(177, 22);
            this.TBConfirmPassword.TabIndex = 12;
            // 
            // TBPatientNumber
            // 
            this.TBPatientNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBPatientNumber.Location = new System.Drawing.Point(267, 173);
            this.TBPatientNumber.Name = "TBPatientNumber";
            this.TBPatientNumber.Size = new System.Drawing.Size(177, 22);
            this.TBPatientNumber.TabIndex = 13;
            // 
            // CBPatientID
            // 
            this.CBPatientID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CBPatientID.AutoSize = true;
            this.CBPatientID.Location = new System.Drawing.Point(267, 135);
            this.CBPatientID.Name = "CBPatientID";
            this.CBPatientID.Size = new System.Drawing.Size(18, 17);
            this.CBPatientID.TabIndex = 14;
            this.CBPatientID.UseVisualStyleBackColor = true;
            // 
            // BTNNewAccount
            // 
            this.BTNNewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNNewAccount.Location = new System.Drawing.Point(267, 208);
            this.BTNNewAccount.Name = "BTNNewAccount";
            this.BTNNewAccount.Size = new System.Drawing.Size(259, 35);
            this.BTNNewAccount.TabIndex = 15;
            this.BTNNewAccount.Text = "Maak nieuw account";
            this.BTNNewAccount.UseVisualStyleBackColor = true;
            this.BTNNewAccount.Click += new System.EventHandler(this.BTNNewAccount_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNCancel.Location = new System.Drawing.Point(3, 208);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(258, 35);
            this.BTNCancel.TabIndex = 16;
            this.BTNCancel.Text = "Annuleren";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // NieuwAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(529, 246);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NieuwAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NieuwAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NieuwAccount_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBPatientNumber;
        private System.Windows.Forms.TextBox TBConfirmPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.CheckBox CBPatientID;
        private System.Windows.Forms.Button BTNNewAccount;
        private System.Windows.Forms.Button BTNCancel;
    }
}