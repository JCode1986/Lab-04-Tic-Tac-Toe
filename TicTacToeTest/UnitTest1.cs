using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {

        Player playerOne = new Player
        {
            Name = "Joseph",
            Marker = "X",
            IsTurn = true
        };

        Player playerTwo = new Player 
        { 
            Name = "Mark", 
            Marker = "O",
            IsTurn = true
        };

        [Fact]
        public void InstantiatedPlayerHasName()
        {
            string expected = "Joseph";
            string actual = playerOne.Name;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void InstantiatedPlayerHasDesignatedMarker()
        {
            string expected = "O";
            string actual = playerTwo.Marker;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void InstantiatedPlayerHasTurn()
        {
            bool actual = playerTwo.IsTurn;
            Assert.True(actual);
        }

        [Fact]
        public void WinnningCombos()
        {
            Game game = new Game(playerOne, playerTwo);

            Board board = new Board();

            string[,] testBoard = new string[,]
            {
                {"O", "X", "O"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };

            board.GameBoard = testBoard;

            bool win = game.CheckForWinner(board);

            Assert.False(win);
        }

        [Fact]
        public void PlayerTurn()
        {
            Assert.False(object.ReferenceEquals(playerOne, playerTwo));
        }
    }
}
