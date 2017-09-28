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

	public abstract class ThingHolder : Thing
	{
		
	}

	public class Room : ThingHolder
	{
		private int _x;
		private int _y;

		public int X
		{
			get { return _x; }
			set { _x = value; }
		}
		public int Y
		{
			get { return _y; }
			set { _y = value; }
		}
	}

	// Actor - Player, Npc
	public abstract class Actor : Thing
	{
		private bool _isalive;

		public bool IsAlive
		{ 
			get { return _isalive; }
			set { _isalive = value; }
		}
	}

	// Items
	public class Item
	{
		private bool _iscollectable;

		public bool IsCollectable
		{
			get { return _iscollectable; }
			set { _iscollectable = value; }
		}

		Item(string Name, string Description, bool IsCollectable)
		{
		}
	}
}