using MatchingSystem;
using NUnit.Framework;

namespace MatchingTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStartGame()
        {
            Game game = new();
            game.StartGame();
            string msg = $"Game starts with number of squares = {game.squares.Count}";
            Assert.IsTrue(game.squares.Count == 16, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestHandleClick()
        {
            Game game = new();
            game.StartGame();
            Assert.IsTrue(game.squares.Count > 0, "Game did not initialize squares.");
            Square square = game.squares[0];
            game.HandleClick(square);
            string msg = $"The square's forecolor before it is clicked is = {square.ForeColor} and after it is clicked it is = {game.SquareForeColor}";
            Assert.IsTrue(square.ForeColor == game.SquareForeColor, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestMatchFound()
        {
            Game game = new();
            game.StartGame();

            game.squares[0].Text = "A";
            game.squares[1].Text = "A";
            game.HandleClick(game.squares[0]);
            game.HandleClick(game.squares[1]);

            string msg = $"FirstClicked: {game.FirstClicked?.Text}, SecondClicked: {game.SecondClicked?.Text} because a match was found";
            Assert.IsTrue(game.FirstClicked == null, "FirstClicked should be null after a match.");
            Assert.IsTrue(game.SecondClicked == null, "SecondClicked should be null after a match.");

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestMatchNotFound()
        {
            Game game = new();
            game.StartGame();

            game.squares[0].Text = "A";
            game.squares[1].Text = "B";
            game.HandleClick(game.squares[0]);
            game.HandleClick(game.squares[1]);

            string msg = $"FirstClicked: {game.FirstClicked?.Text}, SecondClicked: {game.SecondClicked?.Text} after a match was not found";
            Assert.IsTrue(game.FirstClicked != null, msg);
            Assert.IsTrue(game.SecondClicked != null, msg);

            TestContext.WriteLine(msg);
        }

        [Test]

        public void TestResetClickedSquares()
        {
            Game game = new();
            game.StartGame();

            game.squares[0].Text = "A";
            game.squares[1].Text = "B";
            game.HandleClick(game.squares[0]);
            game.HandleClick(game.squares[1]);

            game.ResetClickedSquares();

            string msg = $"There are {game.mismatchedSquares.Count} mismatched squares on the board";
            Assert.IsTrue(game.mismatchedSquares.Count == 0, msg);
            TestContext.WriteLine(msg);
        }
    }
    
}
