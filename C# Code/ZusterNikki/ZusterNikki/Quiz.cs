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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void StartQuizBtn_Click(object sender, EventArgs e)
        {
            StartQuizBtn.Visible = false;
            UitlegQuizBtn.Visible = false;
            QuizTitelLabel.Visible = false;
        }

        private void UitlegQuizBtn_Click(object sender, EventArgs e)
        {
            StartQuizBtn.Visible = false;
            UitlegQuizBtn.Visible = false;
            QuizTitelLabel.Visible = false;
        }

        private void TerugBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
