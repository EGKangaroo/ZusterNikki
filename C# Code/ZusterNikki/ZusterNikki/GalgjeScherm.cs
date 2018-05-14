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
    public partial class GalgjeScherm : Form
    {
        //fields
        private Galgje nieuwSpel;

        //constructors
        public GalgjeScherm()
        {
            InitializeComponent();
        }

        //methods

        //refreshes the viewing screen (letters guessed, number of guesses left, fills in words)
        private void RefreshScreen()
        {
            LBLWrongGuesses.Text = "";
            foreach(var letter in nieuwSpel.WrongGuesses)
            {
                LBLWrongGuesses.Text = LBLWrongGuesses.Text + letter + " ";
            }
            LBLGuessesLeft.Text = nieuwSpel.GuessesLeft + " Gokken Over";
            LBLWord.Text = nieuwSpel.RevealedWord;

            if(nieuwSpel.Win == true)
            {
                BTNNewGame.Enabled = true;
                BTNGuessLetter.Enabled = false;
                MessageBox.Show("Je hebt gewonnen!");
            }

            if(nieuwSpel.GuessesLeft == 0)
            {
                BTNNewGame.Enabled = true;
                BTNGuessLetter.Enabled = false;
                MessageBox.Show("Je hangt!");
            }

            PBXHangMan.ImageLocation = "images/guessesLeft" + nieuwSpel.GuessesLeft + ".png";
        }

        //checks for valid textbox input, only allows controls (i.e. backspace) and letter input
        private void TBGuessLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Je mag alleen letters raden");
                e.Handled = true;
            }
        }

        //lets the user guess the letter specified in the textbox
        private void BTNGuessLetter_Click(object sender, EventArgs e)
        {
            nieuwSpel.Guess(TBGuessLetter.Text);
            RefreshScreen();
        }

        //starts a new game
        private void BTNNewGame_Click(object sender, EventArgs e)
        {
            nieuwSpel = new Galgje();
            RefreshScreen();
            BTNNewGame.Enabled = false;
            BTNGuessLetter.Enabled = true;
        }

        //button lets the user return to main menu
        private void BTNBackToMain_Click(object sender, EventArgs e)
        {
            HoofdMenu newMainMenu = new HoofdMenu();
            newMainMenu.Show();
            this.Dispose();
        }

        //if the x button is pressed, the whole application should close, not just the form
        private void GalgjeScherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
