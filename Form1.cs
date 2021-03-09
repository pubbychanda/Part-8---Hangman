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
        string displayWord;
        int numOfGuesses;
        int numOfWarnings;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            word = "COMPUTER";
            displayWord = "_ _ _ _ _ _ _ _";
            numOfGuesses = 0;
            numOfWarnings = 3;
            lblWord.Text = displayWord;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
                
        }
    }
}
