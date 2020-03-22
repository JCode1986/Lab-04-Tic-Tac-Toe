using Lab04_TicTacToe.Classes;
using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Board board = new Board();
            board.DisplayBoard();
        }
    }
}
