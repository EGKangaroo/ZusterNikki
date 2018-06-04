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
    public partial class Login : Form
    {
        //fields
        SQLHandler sql;

        //properties

        //constructor
        public Login()
        {
            InitializeComponent();
            sql = new SQLHandler();
        }

        //methods/events
        private void MakeMainMenu(Player player)
        {
            this.Hide();
            HoofdMenu newMainMenu = new HoofdMenu(player);
            newMainMenu.Show();
        }

        private void BTNInloggen_Click(object sender, EventArgs e)
        {
            Player player = sql.Login(TBName.Text, TBPassword.Text);

            if(player == null)
            {
                MessageBox.Show("Inloggen mislukt");
            }
            else
            {
                Console.WriteLine(player);
                MakeMainMenu(player);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
