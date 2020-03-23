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

				Console.WriteLine("Player 2 (O) name: ");
				string playerTwoInput = Console.ReadLine();

				GetPlayers(playerOneInput, playerTwoInput);

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

		public static void GetPlayers(string nameOne, string nameTwo)
		{
			Player playerOne = new Player
			{
				Name = nameOne,
				Marker = "X",
				IsTurn = true
			};

			Player playerTwo = new Player
			{
				Name = nameTwo,
				Marker = "O",
				IsTurn = true
			};

			Game game = new Game(playerOne, playerTwo);

			game.Play();

			ContinuePlaying(playerOne, playerTwo);
		}

		public static void ContinuePlaying(Player p1, Player p2)
		{
			bool again = true;

			while (again)
			{
				Console.WriteLine("Would you like to play again? (y/n): ");
				string input = Console.ReadLine().ToLower();

				if (input == "y" || input == "yes")
				{
					Game newGame = new Game(p1, p2);

					newGame.Play();
				}
				else if (input == "n" || input == "no")
				{
					Console.WriteLine("Ok! Come again!");
					again = false;
					Environment.Exit(0);
				}
				else
				{
					ContinuePlaying(p1, p2);
				}
			}
		}
	}
}
