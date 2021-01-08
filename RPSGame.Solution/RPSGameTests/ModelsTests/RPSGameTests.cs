using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPGGameTests
{
	[TestClass]
	public class RPSGameTests
	{
		[TestMethod]
		public void DetermineWinner_PlayerWin_String()
		{
			Game game = new Game("rock", "scissors");
			string result = game.DetermineWinner();
			Assert.AreEqual(result, "win");
		}

		[TestMethod]
		public void DetermineWinner_PlayerLose_String()
		{
			Game game = new Game("scissors", "rock");
			string result = game.DetermineWinner();
			Assert.AreEqual(result, "lose");
		}

		[TestMethod]
		public void DetermineWinner_Tie_String()
		{
			Game game = new Game("paper", "paper");
			string result = game.DetermineWinner();
			Assert.AreEqual(result, "tie");
		}
	}
}