using System;
using Xunit;

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
                {"X", "2", "3"},
                {"X", "5", "6"},
                {"X", "8", "9"},
            };

            board.GameBoard = testBoard;

            bool win = game.CheckForWinner(board);

            Assert.True(win);
        }

        [Fact]
        public void PlayerTurn()
        {
            Game game = new Game(playerOne, playerTwo);
            
        }
    }
}
