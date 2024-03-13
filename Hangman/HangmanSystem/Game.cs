using gnuciDictionary;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler? AllGamesStatusChanged;

        public enum GameStatusEnum { PreGame, JustStarted, Guessed, Mistake, Loser, Winner }
        List<Word> lstword = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        List<string> lstspecialcharacters;
        List<string> lstmysterywordletters = new();

        Random rnd = new();

        //string ss;

        GameStatusEnum _gamestatus = GameStatusEnum.PreGame;
        bool _igiveupbuttonenabled;
        bool _pickawordbuttonenabled = true;
        int _currentpicture = -1;

        public string mysteryword;
        string mysteryletter1;
        string mysteryletter2;
        string mysteryletter3;
        string mysteryletter4;
        string mysteryletter5;
        string mysteryletter6;
        string mysteryletter7;



        public Game()
        {
            numgames++;
            this.GameName = "Game " + numgames;
            for (int i = 0; i < 26; i++)
            {
                this.LetterButtons.Add(new LetterButton());
            }
            for (int i = 0; i < 7; i++)
            {
                this.LetterBoxes.Add(new LetterBox());
            }
            ChangePicture();
            this.LetterButtons.ForEach(b => b.ButtonEnabled = false);

            lstspecialcharacters = new() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "\\", "/", ":", "-" };
            lstword = lstword.Where(w => w.Value.Trim().Length == 7).ToList();

            //ss = JsonConvert.SerializeObject(lstword);

            //DownloadFile();


            lstword = lstword.Where(w => !w.Value.Contains(lstspecialcharacters.ToString())).ToList();
            this.LetterButtons.ForEach(b => b.ButtonColor = this.BlueGameColor);
            this.LetterButtons.ForEach(b => b.ButtonColorMaui = this.BlueGameColorMaui);
        }
        private static int numgames = 0;
        private static int totalgamesplayed = 0;
        private static int totalgameswon = 0;
        public string GameName { get; private set; }
        public static string AllGamesStatus { get => $"Total Wins: {totalgameswon} out of {totalgamesplayed} games"; }

        public GameStatusEnum GameStatus
        {
            get => _gamestatus; set
            {
                _gamestatus = value;
                InvokePropertyChanged();
                InvokePropertyChanged("MessageDisplay");
            }
        }
        public List<LetterButton> LetterButtons { get; private set; } = new();
        public List<LetterBox> LetterBoxes { get; private set; } = new();
        public int CurrentPicture
        {
            get => _currentpicture; set
            {
                _currentpicture = value;
                InvokePropertyChanged();
            }
        }
        public void  DownloadFile()
        {
            //File f = new();

           // return File(new System.Text.UTF8Encoding().GetBytes(ss), "text/json", "ttt");
        }

        public string PicturePath { get => @"\Images\" + CurrentPicture.ToString() + "Mistake.gif"; }
        public string MessageDisplay { get => ChooseDisplayMessage(); }
        public System.Drawing.Color TextColorGuessed { get; set; } = System.Drawing.Color.Black;

        public Microsoft.Maui.Graphics.Color TextColorGuessedMaui
        {
            get => this.ConvertToMauiColor(this.TextColorGuessed);
        }
        public System.Drawing.Color ButtonDisabledColor { get; set; } = System.Drawing.Color.Gray;
        public Microsoft.Maui.Graphics.Color ButtonDisabledColorMaui
        {
            get => this.ConvertToMauiColor(this.ButtonDisabledColor);
        }
        public Color BlueGameColor { get; set; } = Color.FromArgb(25, 150, 192);

        public Microsoft.Maui.Graphics.Color BlueGameColorMaui
        {
            get => this.ConvertToMauiColor(this.BlueGameColor);
        }
        public bool IGiveUpButtonEnabled
        {
            get => _igiveupbuttonenabled; set
            {
                _igiveupbuttonenabled = value;
                InvokePropertyChanged();
            }
        }

        public bool PickAWordButtonEnabled
        {
            get => _pickawordbuttonenabled; set
            {
                _pickawordbuttonenabled = value;
                InvokePropertyChanged();
            }
        }

        public void StartGame()
            
        {
            CurrentPicture = -1;
            ChangePicture();
            this.GameStatus = GameStatusEnum.JustStarted;
            this.LetterButtons.ForEach(b => b.ButtonEnabled = true);
            this.IGiveUpButtonEnabled = true;
            this.PickAWordButtonEnabled = false;

            mysteryword = lstword[rnd.Next(0, lstword.Count())].ToString().ToUpper();

            mysteryletter1 = mysteryword.Substring(0, 1);
            mysteryletter2 = mysteryword.Substring(1, 1);
            mysteryletter3 = mysteryword.Substring(2, 1);
            mysteryletter4 = mysteryword.Substring(3, 1);
            mysteryletter5 = mysteryword.Substring(4, 1);
            mysteryletter6 = mysteryword.Substring(5, 1);
            mysteryletter7 = mysteryword.Substring(6, 1);

            lstmysterywordletters = new() { mysteryletter1, mysteryletter2, mysteryletter3, mysteryletter4, mysteryletter5, mysteryletter6, mysteryletter7 };

            this.LetterBoxes[0].LetterBoxValue = mysteryletter1;
            this.LetterBoxes[1].LetterBoxValue = mysteryletter2;
            this.LetterBoxes[2].LetterBoxValue = mysteryletter3;
            this.LetterBoxes[3].LetterBoxValue = mysteryletter4;
            this.LetterBoxes[4].LetterBoxValue = mysteryletter5;
            this.LetterBoxes[5].LetterBoxValue = mysteryletter6;
            this.LetterBoxes[6].LetterBoxValue = mysteryletter7;

            this.LetterBoxes.ForEach(t => t.TextColor = this.BlueGameColor);
            this.LetterButtons.ForEach(b => b.ButtonColor = this.BlueGameColor);

        }

        public void GuessALetter(string triedletter, int buttonvalue)
        {
            LetterButton letterbutton = this.LetterButtons[buttonvalue];
            this.LetterBoxes.Where(s => s.LetterBoxValue == triedletter).ToList().ForEach(s => s.TextColor = this.TextColorGuessed);

            letterbutton.ButtonEnabled = false;
            letterbutton.ButtonColor = this.ButtonDisabledColor;

            if (lstmysterywordletters.Contains(triedletter))
            {
                this.GameStatus = GameStatusEnum.Guessed;
            }
            else
            {
                ChangePicture();
                this.GameStatus = GameStatusEnum.Mistake;
            }

            DetectWinnerLoser();
            if (this.GameStatus == GameStatusEnum.Loser)
            {
                this.LetterBoxes.ForEach(s => s.TextColor = this.TextColorGuessed);
            }
        }
        public void DetectWinnerLoser()
        {
            if (this.LetterBoxes.Count(s => s.TextColor == this.TextColorGuessed) == 7)
            {
                this.GameStatus = GameStatusEnum.Winner;
                this.PickAWordButtonEnabled = true;
                this.IGiveUpButtonEnabled = false;
                this.LetterButtons.ForEach(b => b.ButtonEnabled = false);
                totalgamesplayed++;
                totalgameswon++;
            }
            if (CurrentPicture == 7)
            {
                this.GameStatus = GameStatusEnum.Loser;
                this.PickAWordButtonEnabled = true;
                this.IGiveUpButtonEnabled = false;
                this.LetterButtons.ForEach(b => b.ButtonEnabled = false);
                totalgamesplayed++;
            }
        }

        public void GiveUp()
        {
            this.GameStatus = GameStatusEnum.PreGame;
            this.LetterBoxes.ForEach(s => s.TextColor = this.TextColorGuessed);
            this.IGiveUpButtonEnabled = false;
            this.PickAWordButtonEnabled = true;
            this.LetterButtons.ForEach(b => b.ButtonEnabled = false);
        }
        private void ChangePicture()
        {
            CurrentPicture = CurrentPicture + 1;
        }

        private string ChooseDisplayMessage()
        {
            string msg = "";
            switch (this.GameStatus)
            {
                case GameStatusEnum.PreGame:
                    msg = "Click Pick a Word for a new challenge!";
                    break;
                case GameStatusEnum.JustStarted:
                    msg = "Pick any letter you like";
                    break;
                case GameStatusEnum.Mistake:
                    msg = "\"Please save me!\"";
                    break;
                case GameStatusEnum.Guessed:
                    msg = "\"You got this one! Get the next one too!\"";
                    break;
                case GameStatusEnum.Loser:
                    msg = "Mr. Hangman is DEAD";
                    break;
                case GameStatusEnum.Winner:
                    msg = "\"Thank you for saving my life!!\"";
                    break;

            }
            return this.GameName + ": " + msg;
        }



        public Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
