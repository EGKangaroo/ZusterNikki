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
        public AdLibsResultScherm(string story, string title)
        {
            InitializeComponent();
            LBLStoryText.Text = story;
            LBLTitle.Text = title;
        }

        private void AdLibsResultScherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
