using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_8___Hangman
{
    public partial class frmMain : Form
    {
        string word;
        string guess;
        string displayWord;
        int numOfGuesses;
        int numOfWarnings;
        char Guess;
        List<string> usedLetters = new List<string>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            word = "COMPUTER";
            displayWord = "--------";
            numOfGuesses = 6;
            numOfWarnings = 3;
            lblWord.Text = displayWord;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = txtGuess.Text.Trim().ToUpper();
            txtGuess.Text = "";
            ///correct guess
            if (word.Contains(guess))
            {
                displayWord = displayWord.Remove(word.IndexOf(guess), 1);
                displayWord = displayWord.Insert(word.IndexOf(guess), guess);
            }
            ///incorrect guess
            else
            {
                usedLetters.Add(guess);
                lstUsedLetters.DataSource = null;
                lstUsedLetters.DataSource = usedLetters;
                numOfGuesses--;
            }



            lblWord.Text = displayWord;
        }
    }
}