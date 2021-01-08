using System;
using RPS.Models;

namespace RPS
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Play Rock Paper Scissors! Do you choose rock, paper, scissors, or shotgun?");
			string playerAnswer = Console.ReadLine().ToLower();
			Game game = new Game(playerAnswer);
			Console.WriteLine("-------------------------");

			// Check for valid input
			if (game.Answers.Contains(playerAnswer) || playerAnswer == "shotgun")
			{
				Console.WriteLine("You played: " + playerAnswer);
				Console.WriteLine("CPU played: " + game.CpuAnswer);
				game.DetermineWinner();
			}
			else
			{
				Console.WriteLine("Please answer with 'rock', 'paper', 'scissors', or 'shotgun'!");
			}

			Main();
		}
	}
}