namespace TextAdventureEngine
{
	// Main Class - Thing
	public abstract class Thing
	{
		private string _name;
		private string _description;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}
	}
}