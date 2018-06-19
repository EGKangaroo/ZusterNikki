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
        Player player;

        string CorrecteAntwoord;
        int gekozen1;
        int gekozen2;
        int gekozen3;
        int gekozen4;
        int Juist;
        int juistgeantwoord;
        int foutgeantwoord;

        private QuizHandler newGame;

        // Constructor
        public Quiz(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void StartQuizBtn_Click(object sender, EventArgs e)
        {
            MainScreenGBox.Visible = false;
            MainScreenGBox.Location = new Point(800, 800);
            ActiveQuizGBox.Visible = true;
            ActiveQuizGBox.Location = new Point(12, 12);
            newGame = new QuizHandler();
            Updater();
        }

        private void UitlegQuizBtn_Click(object sender, EventArgs e)
        {
            QuizUitlegLabel.Text = "De quiz bestaat uit 10 vragen. Zodra je op start drukt krijg jij je eerste \r\nvraag. Daar onder zie je 4 opties. een van die opties \r\nis de juiste. Het is aan jou om er achter te komen welke \r\ndat is. Na dat je alle 10 vragen beantwoord hebt, \r\nkrijg je te zien hoeveel van de vragen jij fout hebt beantwoord.";
            MainScreenGBox.Visible = false;
            MainScreenGBox.Location = new Point(800, 800);
            UitlegGBox.Visible = true;
            UitlegGBox.Location = new Point(12, 12);
        }

        private void TerugBtn_Click(object sender, EventArgs e)
        {
            HoofdMenu newMainMenu = new HoofdMenu(player);
            newMainMenu.Show();
            this.Dispose();
        }

        private void TerugNaarQuizMenuBtn_Click(object sender, EventArgs e)
        {
            UitlegGBox.Visible = false;
            UitlegGBox.Location = new Point(800, 800);
            MainScreenGBox.Visible = true;
            MainScreenGBox.Location = new Point(12, 12);
        }

        private void Updater()
        {
            VraagLabel.Text = newGame.Vraag;
            Antwoord1Btn.Text = newGame.Antwoord1;
            Antwoord2Btn.Text = newGame.Antwoord2;
            Antwoord3Btn.Text = newGame.Antwoord3;
            Antwoord4Btn.Text = newGame.Antwoord4;
            CorrecteAntwoord = newGame.EchteAntwoord;
            Juist = 0;
        }

        private void Antwoord1Btn_Click(object sender, EventArgs e)
        {
            gekozen1 = 1;
            if (gekozen1.ToString() == CorrecteAntwoord)
            {
                Juist = 1;
            }
            else
            {
                Juist = -1;
            }
            Gewonnen();
        }

        private void Antwoord2Btn_Click(object sender, EventArgs e)
        {
            gekozen2 = 2;
            if (gekozen2.ToString() == CorrecteAntwoord)
            {
                Juist = 1;
            }
            else
            {
                Juist = -1;
            }
            Gewonnen();
        }

        private void Antwoord3Btn_Click(object sender, EventArgs e)
        {
            gekozen3 = 3;
            if (gekozen3.ToString() == CorrecteAntwoord)
            {
                Juist = 1;
            }
            else
            {
                Juist = -1;
            }
            Gewonnen();
        }

        private void Antwoord4Btn_Click(object sender, EventArgs e)
        {
            gekozen4 = 4;
            if (gekozen4.ToString() == CorrecteAntwoord)
            {
                Juist = 1;
            }
            else
            {
                Juist = -1;
            }
            Gewonnen();
        }

        private void Gewonnen()
        {
            if (Juist == 1)
            {
                gekozen1 = 0;
                gekozen2 = 0;
                gekozen3 = 0;
                gekozen4 = 0;
                juistgeantwoord++;
                counterGoed.Text = juistgeantwoord.ToString();

                if (newGame.bijgetal < 11)
                {
                    naElkeVraag();
                }
                
                Updater();
            }
            else if (Juist != 1)
            {
                gekozen1 = 0;
                gekozen2 = 0;
                gekozen3 = 0;
                gekozen4 = 0;
                foutgeantwoord++;
                CounterFout.Text = foutgeantwoord.ToString();

                if (newGame.bijgetal < 11)
                {
                    naElkeVraag();
                }

                Updater();
            }
            if (juistgeantwoord == 10 || foutgeantwoord == 10 || juistgeantwoord + foutgeantwoord == 10)
            {
                ActiveQuizGBox.Visible = false;
                ActiveQuizGBox.Location = new Point(800, 800);
                ResultaatGBox.Visible = true;
                ResultaatGBox.Location = new Point(12, 12);
                ResultaatLabel.Text = "Je hebt er " + juistgeantwoord + " goed.";
                int score = juistgeantwoord * 5;
                AddScore(player, score);
                counterGoed.Text = "";
                CounterFout.Text = "";
                juistgeantwoord = 0;
                foutgeantwoord = 0;
                juistgeantwoord = 0;
                foutgeantwoord = 0;
                newGame.bijgetal = 0;
            }
        }

        private void OpnieuwBtn_Click(object sender, EventArgs e)
        {
            counterGoed.Text = "";
            CounterFout.Text = "";
            juistgeantwoord = 0;
            foutgeantwoord = 0;
            ResultaatLabel.Text = "";
            juistgeantwoord = 0;
            foutgeantwoord = 0;
            newGame.bijgetal = 0;
            ResultaatGBox.Visible = false;
            ResultaatGBox.Location = new Point(800, 800);
            ActiveQuizGBox.Visible = true;
            ActiveQuizGBox.Location = new Point(12, 12);
            newGame.NieuweVragen();
            Updater();
        }

        private void naElkeVraag()
        {
                newGame.bijgetal = newGame.bijgetal + 1;
                newGame.VraagAssignation();
        }

        private void AddScore(Player player, int score)
        {
            player.ReceiveScore(score);
        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }

        private void TerugMainBtn_Click(object sender, EventArgs e)
        {
            ResultaatGBox.Visible = false;
            ResultaatGBox.Location = new Point(800, 800);
            MainScreenGBox.Visible = true;
            MainScreenGBox.Location = new Point(12, 12);
        }
    }
}
