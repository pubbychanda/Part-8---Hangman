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
        System.Media.SoundPlayer WinSound, LoseSound;
        string word;
        string guess;
        string displayWord;
        string customDisplayWord;
        string hiddenWord;
        int numOfGuesses;
        int newWord;
        /// <summary>
        /// use better names for lists next time to avoid confusion between listboxes and list<mytype>
        /// </summary>
        List<string> usedLetters = new List<string>();
        List<string> lstWords = new List<string>();
        List<string> lstDisplayWords = new List<string>();
        List<string> lstDisplayCustomWords = new List<string>();
        List<string> lstNewWords = new List<string>();
        List<string> lstHiddenNewWords = new List<string>();
        Random rng = new Random();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstWords.Add("COMPUTER");
            lstWords.Add("FISHSTICKS");
            lstWords.Add("BUTTER");
            lstWords.Add("MINECRAFT");
            lstWords.Add("SPIDER");
            lstWords.Add("CHICKEN");
            lstWords.Add("ALDWORTH");
            lstWords.Add("CUTBLACK");
            ///0-7
            lstDisplayWords.Add("--------");
            lstDisplayWords.Add("----------");
            lstDisplayWords.Add("------");
            lstDisplayWords.Add("---------");
            lstDisplayWords.Add("------");
            lstDisplayWords.Add("-------");
            lstDisplayWords.Add("--------");
            lstDisplayWords.Add("--------");

            newWord = rng.Next(0, 7);
            displayWord = lstDisplayWords[newWord];
            word = lstWords[newWord];

            WinSound = new System.Media.SoundPlayer(Properties.Resources.Win_Sound);
            LoseSound = new System.Media.SoundPlayer(Properties.Resources.Lose_Sound);
       
            numOfGuesses = 6;
            lblWord.Text = displayWord;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtGuess.Text.Trim().Length > 0 && txtGuess.Text.Trim().Length < 2)
            {
                guess = txtGuess.Text.Trim().ToUpper();
                for (int i = 0; word.Length > i; i++)
                {
                    ///correct guess
                    if (word.IndexOf(guess, i) != -1)
                    {
                        displayWord = displayWord.Remove(word.IndexOf(guess, i), 1);
                        displayWord = displayWord.Insert(word.IndexOf(guess, i), guess);
                    }
                    lblWord.Text = displayWord;
                }
                ///incorrect guess
                if (word.IndexOf(guess) == -1)
                {
                    usedLetters.Add(guess);
                    lstUsedLetters.DataSource = null;
                    lstUsedLetters.DataSource = usedLetters;
                    numOfGuesses--;
                    lblDescrition.Text = "Enter a single letter and then press the green button. You have " + numOfGuesses + " attempts or you lose!";
                }


            }
            txtGuess.Text = "";

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
                    LoseSound.Play();
                    lblDescrition.Text = "You have " + numOfGuesses + " attempts. You Lose!";
                    btnGuess.Enabled = false;
                    break;
            }
            ///win check
            if (numOfGuesses >= 0 & !displayWord.Contains("-"))
            {
                WinSound.Play();
                lblDescrition.Text = "You Win!!!! and you still have " + numOfGuesses + " attempt(s) left. Good job! :)";
                btnGuess.Enabled = false;
            }
                
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (chkSelectHiddenWords.Checked == true && lstHiddenNewWords.Count > 0)
            {
                newWord = rng.Next(0, lstNewWords.Count);
                word = lstNewWords[newWord];

                displayWord = lstDisplayCustomWords[newWord];
                lblWord.Text = displayWord;
            }
            else
            {
                newWord = rng.Next(0, 7);
                word = lstWords[newWord];
                displayWord = lstDisplayWords[newWord];
                lblWord.Text = displayWord;
                chkSelectHiddenWords.Checked = false;
            }

            numOfGuesses = 6;
            lblWord.Text = displayWord;
            usedLetters.Clear();
            lstUsedLetters.DataSource = null;
            lstUsedLetters.DataSource = usedLetters;

            lblDescrition.Text = "Enter a single letter and then press the green button. You have " + numOfGuesses + " attempts or you lose!";
            btnGuess.Enabled = true;
        }

        private void btnAddHiddenWord_Click(object sender, EventArgs e)
        {
            if (txtHiddenWord.Text.Trim() != "")
            {
                lstNewWords.Add(txtHiddenWord.Text.Trim().ToUpper());

                for (int i = 0; txtHiddenWord.Text.Length > i; i++)
                {
                    hiddenWord += "*";
                    customDisplayWord += "-";
                }
                lstHiddenNewWords.Add(hiddenWord);
                lstDisplayCustomWords.Add(customDisplayWord);

            }
            txtHiddenWord.Text = "";
            hiddenWord = "";
            customDisplayWord = "";
            lstHiddenWords.DataSource = null;
            lstHiddenWords.DataSource = lstHiddenNewWords;
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lstHiddenWords.SelectedIndex != -1)
            {
                lstHiddenNewWords.RemoveAt(lstHiddenWords.SelectedIndex);
                lstNewWords.RemoveAt(lstHiddenWords.SelectedIndex);
                txtHiddenWord.Text = "";
            }

            lstHiddenWords.DataSource = null;
            lstHiddenWords.DataSource = lstHiddenNewWords;
        }

        private void chkSelectHiddenWords_CheckedChanged(object sender, EventArgs e)
        {
            ///we want to use our custom words
            if (chkSelectHiddenWords.Checked == true && lstHiddenNewWords.Count > 0)
            {
                newWord = rng.Next(0, lstNewWords.Count);
                word = lstNewWords[newWord];

                displayWord = lstDisplayCustomWords[newWord];
                lblWord.Text = displayWord;
            }
            ///we want to use the defalt words 
            else
            {
                newWord = rng.Next(0, 7);
                word = lstWords[newWord];
                displayWord = lstDisplayWords[newWord];
                lblWord.Text = displayWord;
            }
        }
    }
}