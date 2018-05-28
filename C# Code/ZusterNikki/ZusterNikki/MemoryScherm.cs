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
    public partial class MemoryScherm : Form
    {
        //field array cards
        Button[] cards = new Button[16];

        MemoryGameHandler memory;

        public MemoryScherm()
        {
            InitializeComponent();

            cards[0] = BTNCard1;
            cards[1] = BTNCard2;
            cards[2] = BTNCard3;
            cards[3] = BTNCard4;
            cards[4] = BTNCard5;
            cards[5] = BTNCard6;
            cards[6] = BTNCard7;
            cards[7] = BTNCard8;
            cards[8] = BTNCard9;
            cards[9] = BTNCard10;
            cards[10] = BTNCard11;
            cards[11] = BTNCard12;
            cards[12] = BTNCard13;
            cards[13] = BTNCard14;
            cards[14] = BTNCard15;
            cards[15] = BTNCard16;
        }

        private void MemoryScherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void SelectCard(int i)
        {
            memory.FlipCard(memory.Cards[i-1]);
            memory.Score(memory.Cards[i-1]);
            UpdateScreen();
            int j = 0;
            foreach(var card in memory.Cards)
            {
                if(card.Flipped && !card.PairFound)
                {
                    j++;
                }
            }
            if(j == 2)
            {
                WaitToFlipCardTimer.Start();
            }
        }

        public void UpdateScreen()
        {
            for(int i = 0; i < memory.Cards.Length; i++)
            {
                if (memory.Cards[i].Flipped)
                {
                    cards[i].Text = memory.Cards[i].Model;
                }
                else
                {
                    cards[i].Text = "";
                }
            }

            if (memory.Won)
            {
                label1.Text = "Je hebt gewonnen! Wil je nog een keer?";
            }
        }

        public void StartGame(Difficulty selectDifficulty)
        {
            memory = new MemoryGameHandler(selectDifficulty);

            foreach(var card in cards)
            {
                card.Visible = false;
            }

            for (int i = 0; i < memory.Cards.Length; i++)
            {
                cards[i].Visible = true;
            }

            label1.Text = "";
            UpdateScreen();
        }

        private void BTNCard1_Click(object sender, EventArgs e)
        {
            SelectCard(1);
        }

        private void BTNCard2_Click(object sender, EventArgs e)
        {
            SelectCard(2);
        }

        private void BTNCard3_Click(object sender, EventArgs e)
        {
            SelectCard(3);
        }

        private void BTNCard4_Click(object sender, EventArgs e)
        {
            SelectCard(4);
        }

        private void BTNCard5_Click(object sender, EventArgs e)
        {
            SelectCard(5);
        }

        private void BTNCard6_Click(object sender, EventArgs e)
        {
            SelectCard(6);
        }

        private void BTNCard7_Click(object sender, EventArgs e)
        {
            SelectCard(7);
        }

        private void BTNCard8_Click(object sender, EventArgs e)
        {
            SelectCard(8);
        }

        private void BTNCard9_Click(object sender, EventArgs e)
        {
            SelectCard(9);
        }

        private void BTNCard10_Click(object sender, EventArgs e)
        {
            SelectCard(10);
        }

        private void BTNCard11_Click(object sender, EventArgs e)
        {
            SelectCard(11);
        }

        private void BTNCard12_Click(object sender, EventArgs e)
        {
            SelectCard(12);
        }

        private void BTNCard13_Click(object sender, EventArgs e)
        {
            SelectCard(13);
        }

        private void BTNCard14_Click(object sender, EventArgs e)
        {
            SelectCard(14);
        }

        private void BTNCard15_Click(object sender, EventArgs e)
        {
            SelectCard(15);
        }

        private void BTNCard16_Click(object sender, EventArgs e)
        {
            SelectCard(16);
        }

        private void BTNEasy_Click(object sender, EventArgs e)
        {
            StartGame(Difficulty.easy);
        }

        private void BTNMedium_Click(object sender, EventArgs e)
        {
            StartGame(Difficulty.medium);
        }

        private void BTNHard_Click(object sender, EventArgs e)
        {
            StartGame(Difficulty.hard);
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            HoofdMenu newMainMenu = new HoofdMenu();
            newMainMenu.Show();
            this.Dispose();
        }

        private void WaitToFlipCardTimer_Tick(object sender, EventArgs e)
        {
            memory.UnflipCards();
            UpdateScreen();
            WaitToFlipCardTimer.Stop();
        }
    }
}
