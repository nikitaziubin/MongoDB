using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3KM
{
	internal class Room
	{
		public int id { get; set; }
		public int number { get; set; }
		public double area { get; set; }
		public int maxPeron { get; set; }
		public int likes { get; set; }
		public int dislikes { get; set; }
		public int flour { get; set; }
		public List<Sensor> sensors { get; set; } = new List<Sensor>();

		public Room(int id, int number, double area, int maxPeron, int likes, int dislikes, int flour, Sensor sensor)
		{
			this.id = id;
			this.number = number;
			this.area = area;
			this.maxPeron = maxPeron;
			this.likes = likes;
			this.dislikes = dislikes;
			this.flour = flour;
			sensors.Add(sensor);
		}


	}
}
