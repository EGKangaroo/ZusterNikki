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
    enum screenselect
    {
        galgje = 0,
        quiz,
        adlibs,
        uitloggen
    }

    public partial class HoofdMenu : Form
    {
        public HoofdMenu()
        {
            InitializeComponent();
        }
        private void MakeNewScreen(screenselect click)
        {
            switch(click)
            {
                case screenselect.galgje:
                    GalgjeScherm newGalgje = new GalgjeScherm();
                    newGalgje.Show();
                    this.Dispose();
                    break;
                case screenselect.quiz:
                    Quiz newQuiz = new Quiz();
                    newQuiz.Show();
                    this.Dispose();
                    break;
                case screenselect.adlibs:
                    AdLibsScherm newAdLibs = new AdLibsScherm();
                    newAdLibs.Show();
                    this.Dispose();
                    break;
                case screenselect.uitloggen:
                    Login newLogin = new Login();
                    newLogin.Show();
                    this.Dispose();
                    break;
            }
        }

        private void GalgjeBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(screenselect.galgje);
        }

        private void UitlogBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(screenselect.uitloggen);
        }

        private void QuizBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(screenselect.quiz);
        }

        private void AdlibBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(screenselect.adlibs);
        }

        private void HoofdMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
