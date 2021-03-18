
namespace Part_8___Hangman
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.lstUsedLetters = new System.Windows.Forms.ListBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescrition = new System.Windows.Forms.Label();
            this.imgHangman = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstHiddenWords = new System.Windows.Forms.ListBox();
            this.txtHiddenWord = new System.Windows.Forms.TextBox();
            this.btnAddHiddenWord = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSelectHiddenWords = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.AutoSize = true;
            this.lblUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(369, 314);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(127, 25);
            this.lblUsedLetters.TabIndex = 1;
            this.lblUsedLetters.Text = "Used letters";
            // 
            // lstUsedLetters
            // 
            this.lstUsedLetters.FormattingEnabled = true;
            this.lstUsedLetters.Location = new System.Drawing.Point(389, 342);
            this.lstUsedLetters.Name = "lstUsedLetters";
            this.lstUsedLetters.Size = new System.Drawing.Size(86, 108);
            this.lstUsedLetters.TabIndex = 2;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(523, 382);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(41, 31);
            this.txtGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuess.Location = new System.Drawing.Point(570, 382);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(71, 31);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(12, 383);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(339, 58);
            this.lblWord.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(208, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 55);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "HangMan!";
            // 
            // lblDescrition
            // 
            this.lblDescrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrition.Location = new System.Drawing.Point(9, 76);
            this.lblDescrition.Name = "lblDescrition";
            this.lblDescrition.Size = new System.Drawing.Size(619, 22);
            this.lblDescrition.TabIndex = 7;
            this.lblDescrition.Text = "Enter a single letter and then press the green button.  You have 6 attempts or yo" +
    "u lose!";
            // 
            // imgHangman
            // 
            this.imgHangman.Image = global::Part_8___Hangman.Properties.Resources.HangmanFresh;
            this.imgHangman.Location = new System.Drawing.Point(12, 111);
            this.imgHangman.Name = "imgHangman";
            this.imgHangman.Size = new System.Drawing.Size(339, 239);
            this.imgHangman.TabIndex = 0;
            this.imgHangman.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(523, 419);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 31);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstHiddenWords
            // 
            this.lstHiddenWords.FormattingEnabled = true;
            this.lstHiddenWords.Location = new System.Drawing.Point(374, 152);
            this.lstHiddenWords.Name = "lstHiddenWords";
            this.lstHiddenWords.Size = new System.Drawing.Size(122, 147);
            this.lstHiddenWords.TabIndex = 9;
            // 
            // txtHiddenWord
            // 
            this.txtHiddenWord.Location = new System.Drawing.Point(502, 152);
            this.txtHiddenWord.Name = "txtHiddenWord";
            this.txtHiddenWord.PasswordChar = '*';
            this.txtHiddenWord.Size = new System.Drawing.Size(100, 20);
            this.txtHiddenWord.TabIndex = 10;
            // 
            // btnAddHiddenWord
            // 
            this.btnAddHiddenWord.Location = new System.Drawing.Point(608, 150);
            this.btnAddHiddenWord.Name = "btnAddHiddenWord";
            this.btnAddHiddenWord.Size = new System.Drawing.Size(37, 23);
            this.btnAddHiddenWord.TabIndex = 11;
            this.btnAddHiddenWord.Text = "Add";
            this.btnAddHiddenWord.UseVisualStyleBackColor = true;
            this.btnAddHiddenWord.Click += new System.EventHandler(this.btnAddHiddenWord_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteSelected.Location = new System.Drawing.Point(502, 178);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteSelected.TabIndex = 12;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add your own words:";
            // 
            // chkSelectHiddenWords
            // 
            this.chkSelectHiddenWords.AutoSize = true;
            this.chkSelectHiddenWords.Location = new System.Drawing.Point(502, 207);
            this.chkSelectHiddenWords.Name = "chkSelectHiddenWords";
            this.chkSelectHiddenWords.Size = new System.Drawing.Size(117, 17);
            this.chkSelectHiddenWords.TabIndex = 14;
            this.chkSelectHiddenWords.Text = "Use Custom Words";
            this.chkSelectHiddenWords.UseVisualStyleBackColor = true;
            this.chkSelectHiddenWords.CheckedChanged += new System.EventHandler(this.chkSelectHiddenWords_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 462);
            this.Controls.Add(this.chkSelectHiddenWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddHiddenWord);
            this.Controls.Add(this.txtHiddenWord);
            this.Controls.Add(this.lstHiddenWords);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDescrition);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lstUsedLetters);
            this.Controls.Add(this.lblUsedLetters);
            this.Controls.Add(this.imgHangman);
            this.Name = "frmMain";
            this.Text = "Hangman (Game Of The Year Edition)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHangman;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.ListBox lstUsedLetters;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescrition;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstHiddenWords;
        private System.Windows.Forms.TextBox txtHiddenWord;
        private System.Windows.Forms.Button btnAddHiddenWord;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSelectHiddenWords;
    }
}

