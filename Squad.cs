using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_Squad_Manager
{
	class Squad
	{
		private int defendersCnt;
		private int midfieldCnt;

		private List<Player> players;
		
		private readonly int minAge;
		private readonly float avgAge;
		private readonly int maxAge;
		
		private readonly int minOVR;
		private readonly float avgOVR;
		private readonly int maxOVR;

		private readonly float minRating;
		private readonly float avgRating;
		private readonly float maxRating;

		private readonly Dictionary<Player, float> playerIndex;

		internal List<Player> Players { get => players; set => players=value; }
		public int MinAge => minAge;
		public float AvgAge => avgAge;
		public int MaxAge => maxAge;
		public int MinOVR => minOVR;
		public float AvgOVR => avgOVR;
		public int MaxOVR => maxOVR;
		public float MinRating => minRating;
		public float AvgRating => avgRating;
		public float MaxRating => maxRating;

		internal Dictionary<Player, float> PlayerIndex => playerIndex;

		public Squad(List<Player> players)
		{
			if(players!=null){
				this.Players = new List<Player>(players);

				this.minAge=players.Min(p => p.Age);
				this.avgAge=(float)players.Average(p => p.Age);
				this.maxAge=players.Max(p => p.Age);

				this.minOVR=players.Min(p=>p.Ovr);
				this.avgOVR=(float)players.Average(p=>p.Ovr);
				this.maxOVR=players.Max(p => p.Ovr);

				this.minRating=players.Min(p => p.Rating);
				this.avgRating=(float)players.Average(p=>p.Rating);
				this.maxRating=(float)players.Max(p => p.Rating);

				this.playerIndex = new Dictionary<Player, float>();
				for(int  i=0; i<players.Count; i++)
				{
					this.playerIndex.Add(players[i], this.calculateIndex(i));
				}
			}
			else
			{
				this.Players=new List<Player>();
				this.playerIndex=new Dictionary<Player, float>();
			}



		}

		private float calculateIndex(int index)
		{
			if (this.MinAge==this.MaxAge)
				return 0;
			else
				return (float)(0.1*(1-(Players[index].Age-MinAge)/(MaxAge-MinAge))+
					0.3*(Players[index].Ovr-MinOVR)/(MaxOVR-minOVR)+
					0.6*(players[index].Rating-MinRating)/(MaxRating-MinRating));
		}
	}
}
