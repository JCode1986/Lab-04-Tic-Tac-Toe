using Lab04_TicTacToe.Classes;
using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
			StartApp();
		}

		public static string StartApp()
		{
			Console.WriteLine("Welcome To Tic Tac Toe! Wanna Play? (y/n): ");

			string input = Console.ReadLine();

			if (input == "y" || input == "yes")
			{
				Console.WriteLine("Player 1 name: ");
				string playerOneInput = Console.ReadLine();
				Console.WriteLine($"{playerOneInput} you have X's ");

				Player playerOne = new Player
				{
					Name = playerOneInput,
					Marker = "X",
					IsTurn = true,
				};

				Console.WriteLine("Player 2 name: ");
				string playerTwoInput = Console.ReadLine();
				Console.WriteLine($"{playerTwoInput} you have O's ");

				Player playerTwo = new Player
				{
					Name = playerTwoInput,
					Marker = "O",
					IsTurn = true,
				};

				Game game = new Game(playerOne, playerTwo);

				game.Play();

			} else if (input == "n" || input == "no")
			{
				Environment.Exit(0);

			} else
			{
				Console.Clear();
				StartApp();
			}

		return "";
		}
    }
}
