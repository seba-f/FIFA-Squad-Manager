using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_Squad_Manager
{
	class Player
	{
		private string position;
		private string name;
		private int age;
		private int ovr;
		private float rating;

		public Player(string position,string name, int age, int ovr, float rating)
		{
			this.position = position;
			this.Name=name;
			this.Age=age;
			this.Ovr=ovr;
			this.Rating=rating;
		}

		public string Position { get => position; set => position=value; }
		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public int Ovr { get => ovr; set => ovr = value; }
		public float Rating { get => rating; set => rating=value; }
	}
}
