namespace TextAdventureEngine
{
	public static class TextInput
	{
		public static string AcceptStringInput(string userInput)
		{
			userInput = userInput.Trim();
			userInput = userInput.ToUpper();
			return userInput;
		}
	}
}