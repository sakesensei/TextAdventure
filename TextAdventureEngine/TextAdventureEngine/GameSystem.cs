using System;

// Non-thing classes.
// Actions, Read/Write, verbs

namespace TextAdventureEngine
{
	
	public static class Game
	{
		// Get User Input
		public static string Input(string userInput)
		{
			userInput = userInput.Trim();
			userInput = userInput.ToUpper();
			return userInput;
		}

		// Room Title
		public static void RoomTitle(Room myRoom)
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine(myRoom.Name);
		}
	}
}