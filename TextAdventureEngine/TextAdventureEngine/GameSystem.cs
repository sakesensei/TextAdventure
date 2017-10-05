namespace TextAdventureEngine
{
	public class TextInput
	{
		void AcceptStringInput(string userInput)
		{
			userInput.Trim();
			userInput = userInput.ToLower();
		}
	}
}