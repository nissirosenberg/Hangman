using gnuciDictionary;
using Hangman.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        List<Button> lstletterbuttons;
        List<Word> lstword = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        List<string> lstspecialcharacters;
        List<string> lstmysterywordletters;
        List<Label> lstlettertextboxes;

        enum GameStatusEnum { PreGame, JustStarted, Guessed, Mistake, Loser, Winner }
        GameStatusEnum gamestatus;

        Random rnd = new();

        string path = Application.StartupPath + @"\";
        string mysteryword;
        string mysteryletter1;
        string mysteryletter2;
        string mysteryletter3;
        string mysteryletter4;
        string mysteryletter5;
        string mysteryletter6;
        string mysteryletter7;

        int currentpicture = -1;

        public frmHangman()
        {
            InitializeComponent();
            ChangePicture();


            lstlettertextboxes = new() { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7 };
            lstletterbuttons = new() { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };
            lstspecialcharacters = new() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "\\", "/", ":", "-" };
            lstword = lstword.Where(w => w.Value.Trim().Length == 7).ToList();
            lstword = lstword.Where(w => !w.Value.Contains(lstspecialcharacters.ToString())).ToList();



            btnPickAWord.Click += BtnPickAWord_Click;
            lstletterbuttons.ForEach(b => b.Click += LetterButton_Click);
            btnIGiveUp.Click += BtnIGiveUp_Click;
        }

        private void StartGame()
        {
            Color bluegamecolor = Color.FromArgb(25, 150, 192);

            currentpicture = -1;
            ChangePicture();
            gamestatus = GameStatusEnum.JustStarted;

            mysteryword = lstword[rnd.Next(0, lstword.Count())].ToString().ToUpper();

            mysteryletter1 = mysteryword.Substring(0, 1);
            mysteryletter2 = mysteryword.Substring(1, 1);
            mysteryletter3 = mysteryword.Substring(2, 1);
            mysteryletter4 = mysteryword.Substring(3, 1);
            mysteryletter5 = mysteryword.Substring(4, 1);
            mysteryletter6 = mysteryword.Substring(5, 1);
            mysteryletter7 = mysteryword.Substring(6, 1);

            lstmysterywordletters = new() { mysteryletter1, mysteryletter2, mysteryletter3, mysteryletter4, mysteryletter5, mysteryletter6, mysteryletter7 };

            lbl1.Text = mysteryletter1;
            lbl2.Text = mysteryletter2;
            lbl3.Text = mysteryletter3;
            lbl4.Text = mysteryletter4;
            lbl5.Text = mysteryletter5;
            lbl6.Text = mysteryletter6;
            lbl7.Text = mysteryletter7;

            lstlettertextboxes.ForEach(t => t.ForeColor = bluegamecolor);
            lstletterbuttons.ForEach(b => b.Enabled = true);
            lstletterbuttons.ForEach(b => b.BackColor = bluegamecolor);
            btnIGiveUp.Enabled = true;
            btnPickAWord.Enabled = false;
        }

        private void ChangePicture()
        {
            currentpicture = currentpicture + 1;
            pbxHangman.ImageLocation = path + @"\Images\" + currentpicture.ToString() + "Mistake.gif";
        }


        private void DetectWinnerLoser()
        {
            if (lstlettertextboxes.Count(s => s.ForeColor == Color.Black) == 7)
            {
                gamestatus = GameStatusEnum.Winner;
                btnPickAWord.Enabled = true;
                btnIGiveUp.Enabled = false;
                lstletterbuttons.ForEach(b => b.Enabled = false);

            }
            if (currentpicture == 7)
            {
                gamestatus = GameStatusEnum.Loser;
                btnPickAWord.Enabled = true;
                btnIGiveUp.Enabled = false;
                lstletterbuttons.ForEach(b => b.Enabled = false);
            }
        }

        private void DisplayMessage()
        {
            string msg = lblStatus.Text;
            switch (gamestatus)
            {
                case GameStatusEnum.PreGame:
                    lblStatus.Text = "Click Pick a Word for a new challenge!";
                    break;
                case GameStatusEnum.JustStarted:
                    lblStatus.Text = "Pick any letter you like";
                    break;
                case GameStatusEnum.Mistake:
                    lblStatus.Text = "\"Please save me!\"";
                    break;
                case GameStatusEnum.Guessed:
                    lblStatus.Text = "You got this one! Get the next one too!";
                    break;
                case GameStatusEnum.Loser:
                    lblStatus.Text = "Mr. Hangman is DEAD.";
                    break;
                case GameStatusEnum.Winner:
                    lblStatus.Text = "\"Thank you for saving my life!!\"";
                    break;

            }
        }

        private void GuessALetter(Button btn)
        {
            string triedletter = btn.Text;
            lstlettertextboxes.Where(s => s.Text == triedletter).ToList().ForEach(s => s.ForeColor = Color.Black);

            btn.Enabled = false;
            btn.BackColor = Color.Gray;

            if (lstmysterywordletters.Contains(triedletter))
            {
                gamestatus = GameStatusEnum.Guessed;
            }
            else
            {
                ChangePicture();
                gamestatus = GameStatusEnum.Mistake;
            }

            DetectWinnerLoser();
            if (gamestatus == GameStatusEnum.Loser)
            {
                lstlettertextboxes.ForEach(s => s.ForeColor = Color.Black);
            }

        }


        private void BtnIGiveUp_Click(object? sender, EventArgs e)
        {
            gamestatus = GameStatusEnum.PreGame;
            lstlettertextboxes.ForEach(s => s.ForeColor = Color.Black);
            lstletterbuttons.ForEach(b => b.Enabled = false);
            btnPickAWord.Enabled = true;
            btnIGiveUp.Enabled = false;
            DisplayMessage();
        }

        private void BtnPickAWord_Click(object? sender, EventArgs e)
        {
            StartGame();
            DisplayMessage();
        }

        private void LetterButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                GuessALetter(btn);
                DisplayMessage();
            }
        }



    }
}
