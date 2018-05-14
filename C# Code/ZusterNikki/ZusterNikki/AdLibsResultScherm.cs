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
    public partial class AdLibsResultScherm : Form
    {
        public AdLibsResultScherm(string story)
        {
            InitializeComponent();
            LBLStoryText.Text = story;
        }

        private void AdLibsResultScherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
