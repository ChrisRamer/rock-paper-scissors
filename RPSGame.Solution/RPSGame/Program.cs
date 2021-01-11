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
				string result = game.DetermineWinner();
				WriteToConsole(result, game.PlayerAnswer, game.CpuAnswer);
			}
			else
			{
				Console.WriteLine("Please answer with 'rock', 'paper', 'scissors', or 'shotgun'!");
			}

			Main();
		}

		static void WriteToConsole(string result, string playerAnswer, string cpuAnswer)
		{
			Console.WriteLine("-------------------------");

			switch (result)
			{
				case "win":
					Console.WriteLine(playerAnswer + " > " + cpuAnswer);
					Console.WriteLine("You won! Congrats!");
					break;
				case "lose":
					Console.WriteLine(playerAnswer + " < " + cpuAnswer);
					Console.WriteLine("CPU won! Better luck next time, I guess...");
					break;
				case "tie":
					Console.WriteLine("Woah! It's a tie! Imagine that! o:");
					break;
			}

			Console.WriteLine("-------------------------");
		}
	}
}