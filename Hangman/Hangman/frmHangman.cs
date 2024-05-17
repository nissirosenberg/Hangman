using gnuciDictionary;
using System.Data;
using HangmanSystem;
namespace Hangman
{
    public partial class frmHangman : Form
    {
        Game game = new();
        List<Label> lstletterboxes = new();
        List<Button> lstletterbuttons = new();
        List<Image> lstimages = new();

        public string path = Application.StartupPath + @"\";

        public frmHangman()
        {
            InitializeComponent();
            lstletterboxes = new() { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7 };
            lstletterbuttons = new() { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };
            btnIGiveUp.Click += BtnIGiveUp_Click;
            lblStatus.DataBindings.Add("Text", game, "MessageDisplay");
            btnIGiveUp.DataBindings.Add("Enabled", game, "IGiveUpButtonEnabled");
            btnPickAWord.DataBindings.Add("Enabled", game, "PickAWordButtonEnabled");
            btnPickAWord.Click += BtnPickAWord_Click;
            lstletterbuttons.ForEach(b =>
            {
                LetterButton letterbutton = game.LetterButtons[lstletterbuttons.IndexOf(b)];
                b.Click += LetterButton_Click;
                b.DataBindings.Add("Backcolor", letterbutton, "ButtonColor");
                b.DataBindings.Add("Enabled", letterbutton, "ButtonEnabled");
            });
            lstletterboxes.ForEach(b =>
            {
                LetterBox letterbox = game.LetterBoxes[lstletterboxes.IndexOf(b)];
                b.DataBindings.Add("Text", letterbox, "LetterBoxValue");
                b.DataBindings.Add("Forecolor", letterbox, "TextColor");
            });
            pbxHangman.ImageLocation = path + @"\Images\" + "0Mistake.gif";
        }

        private void StartGame()
        {
            game.StartGame();
        }

        private void GuessALetter(string buttontext, Button btn, string startuppath)
        {
            int num = lstletterbuttons.IndexOf(btn);
            game.GuessALetter(buttontext, num, startuppath);
            pbxHangman.DataBindings.Clear();
            pbxHangman.DataBindings.Add("ImageLocation", game, "WindowsPicturePath");
        }

        private void GiveUp()
        {
            game.GiveUp();
        }

        private void BtnIGiveUp_Click(object? sender, EventArgs e)
        {
            GiveUp();
        }

        private void BtnPickAWord_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

        private void LetterButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                GuessALetter(btn.Text, btn, path);
            }
        }



    }
}
