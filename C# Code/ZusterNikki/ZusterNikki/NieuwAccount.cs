using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZusterNikki
{
    public partial class NieuwAccount : Form
    {
        public NieuwAccount()
        {
            InitializeComponent();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            Login loginScherm = new Login();
            loginScherm.Show();
            this.Hide();
        }

        private void BTNNewAccount_Click(object sender, EventArgs e)
        {
            SQLHandler sql = new SQLHandler();

            if (CBPatientID.Checked)
            {
                bool result = Int32.TryParse(TBPatientNumber.Text, out int number);
                if (!result)
                {
                    MessageBox.Show("Geen geldig nummer!");
                    return;
                }

                if(!sql.MakeNewAccount(TBPassword.Text, TBConfirmPassword.Text, TBName.Text, number))
                {
                    MessageBox.Show("Account aanmaken mislukt!");
                }
                else
                {
                    MessageBox.Show("Account aangemaakt!");
                    Login loginScherm = new Login();
                    loginScherm.Show();
                    this.Hide();
                }
            }
            else
            {
                if(!sql.MakeNewAccount(TBPassword.Text, TBConfirmPassword.Text, TBName.Text))
                {
                    MessageBox.Show("Account aanmaken mislukt!");
                }
                else
                {
                    MessageBox.Show("Account aangemaakt!");
                    Login loginScherm = new Login();
                    loginScherm.Show();
                    this.Hide();
                }
            }
        }

        private void NieuwAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
