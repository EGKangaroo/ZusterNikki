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

        //properties

        //constructor
        public Login()
        {
            InitializeComponent();
        }

        //methods/events
        private void MakeMainMenu()
        {
            this.Hide();
            HoofdMenu newMainMenu = new HoofdMenu();
            newMainMenu.Show();
        }

        private void BTNInloggen_Click(object sender, EventArgs e)
        {
            MakeMainMenu();
        }
    }
}
