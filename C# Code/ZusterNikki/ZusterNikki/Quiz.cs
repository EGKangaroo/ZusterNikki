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
        // Field
        string CorrecteAntwoord;
        int gekozen1;
        int gekozen2;
        int gekozen3;
        int gekozen4;
        bool Juist;
        int juistgeantwoord;
        int foutgeantwoord;

        private QuizHandler newGame;
        public Quiz()
        {
            InitializeComponent();
            QuizTitelLabel.Visible = true;
            QuizTitelLabel.Text = "Quiz";
            QuizTitelLabel.Location = new Point(304, 103);
            UitlegQuizBtn.Visible = true;
            UitlegQuizBtn.Location = new Point(267, 250);
            StartQuizBtn.Visible = true;
            StartQuizBtn.Location = new Point(267, 356);
            TerugBtn.Visible = true;
            TerugBtn.Location = new Point(653, 482);
        }

        private void StartQuizBtn_Click(object sender, EventArgs e)
        {
            StartQuizBtn.Visible = false;
            UitlegQuizBtn.Visible = false;
            QuizTitelLabel.Visible = false;
            VraagLabel.Visible = true;
            VraagLabel.Location = new Point(50, 70);
            Antwoord1Btn.Visible = true;
            Antwoord1Btn.Location = new Point(200, 200);
            Antwoord2Btn.Visible = true;
            Antwoord2Btn.Location = new Point(370, 200);
            Antwoord3Btn.Visible = true;
            Antwoord3Btn.Location = new Point(200, 370);
            Antwoord4Btn.Visible = true;
            Antwoord4Btn.Location = new Point(370, 370);
            Updater();
        }

        private void UitlegQuizBtn_Click(object sender, EventArgs e)
        {
            TerugNaarQuizMenuBtn.Visible = true;
            TerugNaarQuizMenuBtn.Location = new Point(653, 482);
            QuizUitlegLabel.Text = "De quiz bestaat uit 10 vragen. Zodra je op start drukt krijg jij je eerste \r\nvraag. Daar onder zie je 4 opties. een van die opties \r\nis de juiste. Het is aan jou om er achter te komen welke \r\ndat is. Na dat je alle 10 vragen beantwoord hebt, \r\nkrijg je te zien hoeveel van de vragen jij fout hebt beantwoord.";
            QuizUitlegLabel.Visible = true;
            QuizUitlegLabel.Location = new Point(50, 70);
            StartQuizBtn.Visible = false;
            UitlegQuizBtn.Visible = false;
            QuizTitelLabel.Visible = false;
            TerugBtn.Visible = false;
        }

        private void TerugBtn_Click(object sender, EventArgs e)
        {

        }

        private void TerugNaarQuizMenuBtn_Click(object sender, EventArgs e)
        {
            TerugNaarQuizMenuBtn.Visible = false;
            QuizUitlegLabel.Visible = false;
            QuizTitelLabel.Visible = true;
            UitlegQuizBtn.Visible = true;
            StartQuizBtn.Visible = true;
            TerugBtn.Visible = true;
        }

        private void Updater()
        {
            newGame = new QuizHandler();
            VraagLabel.Text = newGame.Vraag;
            Antwoord1Btn.Text = newGame.Antwoord1;
            Antwoord2Btn.Text = newGame.Antwoord2;
            Antwoord3Btn.Text = newGame.Antwoord3;
            Antwoord4Btn.Text = newGame.Antwoord4;
            CorrecteAntwoord = newGame.EchteAntwoord;
        }

        private void Antwoord1Btn_Click(object sender, EventArgs e)
        {
            gekozen1 = 1;
            if (gekozen1.ToString() == CorrecteAntwoord)
            {
                Juist = true;
                Gewonnen();
            }
            if (gekozen1.ToString() != CorrecteAntwoord)
            {
                Juist = false;
                Gewonnen();
            }

        }

        private void Antwoord2Btn_Click(object sender, EventArgs e)
        {
            gekozen2 = 2;
            if (gekozen2.ToString() == CorrecteAntwoord)
            {
                Juist = true;
                Gewonnen();
            }
            if (gekozen2.ToString() != CorrecteAntwoord)
            {
                Juist = false;
                Gewonnen();
            }
        }

        private void Antwoord3Btn_Click(object sender, EventArgs e)
        {
            gekozen3 = 3;
            if (gekozen3.ToString() == CorrecteAntwoord)
            {
                Juist = true;
                Gewonnen();
            }
            if (gekozen3.ToString() != CorrecteAntwoord)
            {
                Juist = false;
                Gewonnen();
            }
        }

        private void Antwoord4Btn_Click(object sender, EventArgs e)
        {
            gekozen4 = 4;
            if (gekozen4.ToString() == CorrecteAntwoord)
            {
                Juist = true;
                Gewonnen();
            }
            if (gekozen4.ToString() != CorrecteAntwoord)
            {
                Juist = false;
                Gewonnen();
            }
        }

        private void Gewonnen()
        {
            if (Juist == true)
            {
                gekozen1 = 0;
                gekozen2 = 0;
                gekozen3 = 0;
                gekozen4 = 0;
                Updater();
                juistgeantwoord++;
                label1.Text = juistgeantwoord.ToString();
            }
            if (Juist == false)
            {
                gekozen1 = 0;
                gekozen2 = 0;
                gekozen3 = 0;
                gekozen4 = 0;
                Updater();
                foutgeantwoord++;
                label2.Text = foutgeantwoord.ToString();
            }
        }
    }
}
