using System;
using System.Collections.Generic;

namespace RPS.Models
{
	public class Game
	{
		public string PlayerAnswer { get; set; }
		public string CpuAnswer { get; set; }
		public List<string> Answers = new List<string>() { "rock", "paper", "scissors" };

		public Game(string playerChoice)
		{
			this.PlayerAnswer = playerChoice.ToLower();
			this.CpuAnswer =GetCPUAnswer();
		}

		public string GetCPUAnswer()
		{
			Random random = new Random();
			int randomNumer = random.Next(0, Answers.Count);
			return Answers[randomNumer];
		}

		public string DetermineWinner()
		{
			string result;

			if (PlayerAnswer == CpuAnswer)
			{
				// Tie
				result = "tie";
			}
			else if (PlayerAnswer == "shotgun" || (PlayerAnswer == "rock" && CpuAnswer == "scissors") || (PlayerAnswer == "scissors" && CpuAnswer == "paper") || (PlayerAnswer == "paper" && CpuAnswer == "rock"))
			{
				// Win
				 result = "win";
			}
			else
			{
				// Lose
				result = "lose";
			}

			return result;
		}
	}
}