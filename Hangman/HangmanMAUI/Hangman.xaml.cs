using HangmanSystem;
namespace HangmanMAUI;

public partial class Hangman : ContentPage
{
    Game activegame;
    List<Game> lstgame = new() { new Game(), new Game(), new Game() };
    List<Button> lstletterbuttons = new();
    public Hangman()
    {
        InitializeComponent();
        lstgame.ForEach(g => g.AllGamesStatusChanged += G_AllGamesStatusChanged);
        Game1Rb.BindingContext = lstgame[0];
        Game2Rb.BindingContext = lstgame[1];
        Game3Rb.BindingContext = lstgame[2];
        activegame = lstgame[0];
        this.BindingContext = activegame;
        lstletterbuttons = new() { ABtn, BBtn, CBtn, DBtn, EBtn, FBtn, GBtn, HBtn, IBtn, JBtn, KBtn, LBtn, MBtn, NBtn, OBtn, PBtn, QBtn, RBtn, SBtn, TBtn, UBtn, VBtn, WBtn, XBtn, YBtn, ZBtn };
        //lstletterbuttons.ForEach(b =>
        //{
        //    LetterButton letterbutton = activegame.LetterButtons[lstletterbuttons.IndexOf(b)];
        //    b.BindingContext = ("Enabled", letterbutton, "ButtonEnabled");
        //});

    }

    private void G_AllGamesStatusChanged(object sender, EventArgs e)
    {
        GameStatusLbl.Text = Game.AllGamesStatus;
    }

    private void Btn_Clicked(object sender, EventArgs e)
    {
        if (sender is Button)
        {
            Button btn = (Button)sender;
            activegame.GuessALetter(btn.Text, lstletterbuttons.IndexOf(btn));
        }

    }

    private void IGiveUpBtn_Clicked(object sender, EventArgs e)
    {
        activegame.GiveUp();
    }

    private void PickAWordBtn_Clicked(object sender, EventArgs e)
    {
        activegame.StartGame();
    }

    private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        if (rb.IsChecked && rb.BindingContext != null)
        {
            activegame = (Game)rb.BindingContext;
            this.BindingContext = activegame;
        }
    }
}