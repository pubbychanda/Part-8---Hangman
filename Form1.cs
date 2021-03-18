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
        int newWord;
        char[] charGuess;
        List<string> usedLetters = new List<string>();
        List<string> lstWords = new List<string>();
        List<string> lstDisplayWords = new List<string>();
        Random rng = new Random();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstWords.Add("COMPUTER");
            ///two s's
            lstWords.Add("FISHSTICK");
            ///word with two T's is not working
            lstWords.Add("BUTTER");
            lstWords.Add("MINECRAFT");
            lstWords.Add("SPIDER");
            lstWords.Add("CHICKEN");
            lstWords.Add("ALDWORTH");
            lstWords.Add("CUTBLACK");
            ///0-7
            lstDisplayWords.Add("--------");
            lstDisplayWords.Add("---------");
            lstDisplayWords.Add("------");
            lstDisplayWords.Add("---------");
            lstDisplayWords.Add("------");
            lstDisplayWords.Add("-------");
            lstDisplayWords.Add("---------");
            lstDisplayWords.Add("--------");

            newWord = rng.Next(0, 7);
            displayWord = lstDisplayWords[newWord];
            word = lstWords[newWord];
       
            numOfGuesses = 6;
            lblWord.Text = displayWord;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = txtGuess.Text.Trim().ToUpper();
            charGuess = guess.ToCharArray();
            txtGuess.Text = "";
            ///correct guess
            if (word.Contains(guess))
            {
                for (int i = 1; guess.Max() > i; i++)
                {
                    if (word.IndexOfAny(charGuess, i) != -1)
                    {
                        displayWord = displayWord.Remove(word.IndexOfAny(charGuess, i), 1);
                        displayWord = displayWord.Insert(word.IndexOfAny(charGuess), guess);
                    }
                }
                lblWord.Text = displayWord;
            }
            ///incorrect guess
            else
            {
                usedLetters.Add(guess);
                lstUsedLetters.DataSource = null;
                lstUsedLetters.DataSource = usedLetters;
                numOfGuesses--;
                lblDescrition.Text = "Enter a single letter and then press the green button. You have " + numOfGuesses +" attempts or you lose!";
            }

            switch (numOfGuesses)
            {
                case 6:
                    imgHangman.Image = Properties.Resources.HangmanFresh;
                    break;
                case 5:
                    imgHangman.Image = Properties.Resources.HangmanHead;
                    break;
                case 4:
                    imgHangman.Image = Properties.Resources.HangmanBody;
                    break;
                case 3:
                    imgHangman.Image = Properties.Resources.HangmanLeg1;
                    break;
                case 2:
                    imgHangman.Image = Properties.Resources.HangmanLeg2;
                    break;
                case 1:
                    imgHangman.Image = Properties.Resources.HangmanArm1;
                    break;
                ///lose check
                case 0:
                    imgHangman.Image = Properties.Resources.HangmanArm2;
                    lblDescrition.Text = "You have " + numOfGuesses + " attempts. You Lose!";
                    btnGuess.Enabled = false;
                    break;
            }
            ///win check
            if (numOfGuesses >= 0 & !displayWord.Contains("-"))
            {
                lblDescrition.Text = "You Win!!!! and you still have " + numOfGuesses + " attempt(s) left. Good job! :)";

            }
                
        }
    }
}