using HangmanSystem;

namespace HangmanTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StartGame()
        {
            Game game = new();
            game.StartGame();
            string firstletter = game.LetterBoxes[0].LetterBoxValue;
            string msg = $"Game status: {game.GameStatus.ToString()} and first letterbox has letter {firstletter}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.JustStarted && firstletter != null, msg); ;
            TestContext.WriteLine(msg);
        }

        [Test]
        public void GuessALetter()
        {
            Game game = new();
            game.StartGame();
            LetterButton button = game.LetterButtons[0];
            string firstletter = game.LetterBoxes[0].LetterBoxValue;
            game.GuessALetter(firstletter, 0);
            string msg = $"The first letter, {firstletter}, was guessed and it turned {game.LetterBoxes[0].TextColor.ToString()}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Guessed && game.LetterBoxes[0].TextColor == game.TextColorGuessed, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void DetectWinner()
        {
            Game game = new();
            game.StartGame();
            string letter1 = game.LetterBoxes[0].LetterBoxValue;
            string letter2 = game.LetterBoxes[1].LetterBoxValue;
            string letter3 = game.LetterBoxes[2].LetterBoxValue;
            string letter4 = game.LetterBoxes[3].LetterBoxValue;
            string letter5 = game.LetterBoxes[4].LetterBoxValue;
            string letter6 = game.LetterBoxes[5].LetterBoxValue;
            string letter7 = game.LetterBoxes[6].LetterBoxValue;
            LetterButton button1 = game.LetterButtons[0];
            LetterButton button2 = game.LetterButtons[1];
            LetterButton button3 = game.LetterButtons[2];
            LetterButton button4 = game.LetterButtons[3];
            LetterButton button5 = game.LetterButtons[4];
            LetterButton button6 = game.LetterButtons[5];
            LetterButton button7 = game.LetterButtons[6];
            game.GuessALetter(letter1, 0);
            game.GuessALetter(letter2, 1);
            game.GuessALetter(letter3, 2);
            game.GuessALetter(letter4, 3);
            game.GuessALetter(letter5, 4);
            game.GuessALetter(letter6, 5);
            game.GuessALetter(letter7, 6);
            string msg = $"Current game status: {game.GameStatus.ToString()} and amount of black letters: {game.LetterBoxes.Count(t => t.TextColor == game.TextColorGuessed)}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Winner && game.LetterBoxes.Count(t => t.TextColor == game.TextColorGuessed) == 7, msg);//game.LetterBoxes.Count);
            TestContext.Write(msg);
        }
    }
}