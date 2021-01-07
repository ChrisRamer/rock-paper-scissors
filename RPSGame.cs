using System;
using System.Collections.Generic;

class RPSGame
{
	public class GameData
	{
		public string answer;
		public List<string> answersItWinsOver = new List<string>();

		public GameData(string answer, List<string> answersItWinsOver)
		{
			this.answer = answer;
			this.answersItWinsOver = answersItWinsOver;
		}
	}

	static void Main()
	{
		PlayGame();
	}

	static void PlayGame(string startMessage = "")
	{
		List<GameData> gameData = new List<GameData>()
		{
			new GameData("rock", new List<string>() { "scissors" }),
			new GameData("paper", new List<string>() { "rock" }),
			new GameData("scissors", new List<string>() { "paper" }),
			new GameData("shotgun", new List<string>() { "rock", "paper", "scissors" })
		};

		// Start game
		if (string.IsNullOrEmpty(startMessage))
		{
			Console.WriteLine("Play Rock Paper Scissors with me! Do you choose rock, paper, scissors, or shotgun?");
		}
		else
		{
			Console.WriteLine(startMessage);
		}

		string playerAnswer = Console.ReadLine();

		for (int i = 0; i < gameData.Count;  i++)
		{
			// If valid answer
			if (playerAnswer == gameData[i].answer)
			{
				Random rand = new Random();
				int randNum = rand.Next(0, gameData.Count - 1);
				string cpuAnswer = gameData[randNum].answer;
				Console.WriteLine("CPU played: " + cpuAnswer);
				DetermineWinner(playerAnswer, cpuAnswer, gameData[randNum].answersItWinsOver);
				return;
			}
		}

		// If invalid answer
		Console.WriteLine("Please answer with 'rock', 'paper', 'scissors', or 'shotgun'!");

		PlayGame("Care to try again? Rock, paper, or scissors?");
	}

	static void DetermineWinner(string playerAnswer, string cpuAnswer, List<string> eval)
	{
		// If tie
		if (playerAnswer == cpuAnswer)
		{
			Console.WriteLine(playerAnswer + " = " + cpuAnswer);
			Console.WriteLine("A tie! Woah! Everybody wins!");
		}
		// If CPU won
		else if (eval.Contains(playerAnswer))
		{
			Console.WriteLine(playerAnswer + " < " + cpuAnswer);
			Console.WriteLine("CPU won! Better luck next time!");
		}
		// If player won
		else
		{
			Console.WriteLine(playerAnswer + " > " + cpuAnswer);
			Console.WriteLine("You won! Congrats!");
		}

		PlayGame("Care to play again? Rock, paper, scissors, or shotgun?");
	}
}