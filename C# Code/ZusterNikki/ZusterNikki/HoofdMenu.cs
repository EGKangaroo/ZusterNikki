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
    enum ScreenSelect
    {
        galgje = 0,
        quiz,
        adlibs,
        memory,
        uitloggen
    }

    public partial class HoofdMenu : Form
    {
        public HoofdMenu()
        {
            InitializeComponent();
        }
        private void MakeNewScreen(ScreenSelect click)
        {
            switch(click)
            {
                case ScreenSelect.galgje:
                    GalgjeScherm newGalgje = new GalgjeScherm();
                    newGalgje.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.quiz:
                    Quiz newQuiz = new Quiz();
                    newQuiz.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.adlibs:
                    AdLibsScherm newAdLibs = new AdLibsScherm();
                    newAdLibs.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.memory:
                    MemoryScherm memory = new MemoryScherm();
                    memory.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.uitloggen:
                    Login newLogin = new Login();
                    newLogin.Show();
                    this.Dispose();
                    break;
            }
        }

        private void GalgjeBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(ScreenSelect.galgje);
        }

        private void UitlogBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(ScreenSelect.uitloggen);
        }

        private void QuizBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(ScreenSelect.quiz);
        }

        private void AdlibBtn_Click(object sender, EventArgs e)
        {
            MakeNewScreen(ScreenSelect.adlibs);
        }

        private void BTNMemorySelect_Click(object sender, EventArgs e)
        {
            MakeNewScreen(ScreenSelect.memory);
        }

        private void HoofdMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
