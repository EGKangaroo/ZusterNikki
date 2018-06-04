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
        Player player;

        public AdLibsResultScherm(string story, string title, Player player)
        {
            InitializeComponent();
            LBLStoryText.Text = story;
            LBLTitle.Text = title;
            this.player = player;
        }

        private void AdLibsResultScherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLHandler sql = new SQLHandler();
            sql.UpdateScore(player);
            Application.Exit();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            HoofdMenu newMain = new HoofdMenu(player);
            newMain.Show();
            this.Dispose();
        }
    }
}
