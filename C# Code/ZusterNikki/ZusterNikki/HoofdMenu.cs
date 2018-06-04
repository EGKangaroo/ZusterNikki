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
        //field
        Player player;

        public HoofdMenu(Player player)
        {
            InitializeComponent();
            this.player = player;

            LBLGreetingText.Text = "Hallo " + player.Name + "! Ik ben Zuster Nikki!";
            LBLScore.Text = "Je hebt een score van " + player.Score;
        }
        private void MakeNewScreen(ScreenSelect click)
        {
            switch(click)
            {
                case ScreenSelect.galgje:
                    GalgjeScherm newGalgje = new GalgjeScherm(player);
                    newGalgje.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.quiz:
                    Quiz newQuiz = new Quiz(player);
                    newQuiz.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.adlibs:
                    AdLibsScherm newAdLibs = new AdLibsScherm(player);
                    newAdLibs.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.memory:
                    MemoryScherm memory = new MemoryScherm(player);
                    memory.Show();
                    this.Dispose();
                    break;
                case ScreenSelect.uitloggen:
                    SQLHandler sql = new SQLHandler();
                    sql.UpdateScore(player);
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
            SQLHandler sql = new SQLHandler();
            sql.UpdateScore(player);
            Application.Exit();
        }
    }
}
