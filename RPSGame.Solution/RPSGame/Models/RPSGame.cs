using System;
using System.Collections.Generic;

namespace RPS.Models
{
	public class Game
	{
		public string PlayerAnswer;
		public string CpuAnswer;
		public List<string> Answers = new List<string>() { "rock", "paper", "scissors" };

		public Game(string playerChoice, string cpuChoice = "")
		{
			this.PlayerAnswer = playerChoice.ToLower();
			this.CpuAnswer = string.IsNullOrEmpty(cpuChoice) ? GetCPUAnswer() : cpuChoice;
		}

		string GetCPUAnswer()
		{
			Random random = new Random();
			int randomNumer = random.Next(0, Answers.Count);
			return Answers[randomNumer];
		}

		public string DetermineWinner()
		{
			string result;
			Console.WriteLine("-------------------------");

			if (PlayerAnswer == CpuAnswer)
			{
				// Tie
				Console.WriteLine("Woah! It's a tie! Imagine that! o:");
				result = "tie";
			}
			else if (PlayerAnswer == "shotgun" || (PlayerAnswer == "rock" && CpuAnswer == "scissors") || (PlayerAnswer == "scissors" && CpuAnswer == "paper") || (PlayerAnswer == "paper" && CpuAnswer == "rock"))
			{
				// Win
				Console.WriteLine(PlayerAnswer + " > " + CpuAnswer);
				Console.WriteLine("You won! Congrats!");
				 result = "win";
			}
			else
			{
				// Lose
				Console.WriteLine(PlayerAnswer + " < " + CpuAnswer);
				Console.WriteLine("CPU won! Better luck next time, I guess...");
				result = "lose";
			}

			Console.WriteLine("-------------------------");
			return result;
		}
	}
}