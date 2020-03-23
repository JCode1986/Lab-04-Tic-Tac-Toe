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

		public static void StartApp()
		{

			Console.WriteLine("Welcome To Tic Tac Toe! Wanna Play? (y/n): ");

			string input = Console.ReadLine().ToLower();

			if (input == "y" || input == "yes")
			{
				Console.WriteLine("Player 1 (X) name: ");
				string playerOneInput = Console.ReadLine();
				Console.WriteLine($"{playerOneInput} you have X's ");

				Player playerOne = new Player
				{
					Name = playerOneInput,
					Marker = "X",
				};

				Console.WriteLine("Player 2 (O) name: ");
				string playerTwoInput = Console.ReadLine();

				Player playerTwo = new Player
				{
					Name = playerTwoInput,
					Marker = "O",
				};

				Game game = new Game(playerOne, playerTwo);

				game.Play();

			}
			else if (input == "n" || input == "no")
			{
				Console.WriteLine("Ok! Come again!");
				Environment.Exit(0);
			}
			else
			{
				Console.Clear();
				StartApp();
			}
		}
	}
}
