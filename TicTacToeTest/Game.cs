using System;

namespace TicTacToeTest
{
    internal class Game
    {
        private Player playerOne;
        private Player playerTwo;

        public Game(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        public Board Board { get; internal set; }

        internal void CheckForWinner(string[,] test)
        {
            throw new NotImplementedException();
        }

        internal bool CheckForWinner(Board board)
        {
            throw new NotImplementedException();
        }

        internal void SwitchPlayer()
        {
            throw new NotImplementedException();
        }
    }
}