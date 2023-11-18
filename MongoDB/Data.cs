using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
	class Data
	{

		//public int id { get; set; }	
		public double temperature { get; set; }
		public double pressure { get; set; }
		public double humidity { get; set; }
		public DateTime DateTime { get; set; }
		public int roomId { get; set; }
		Random rand = new Random();

		public Data()
		{
			//this.id = id;
			roomId = rand.Next(1, 300);
			temperature = rand.Next(-3, 38);
			pressure = rand.Next(760, 1013);
			humidity = rand.Next(30, 50);
			DateTime = DateTime.UtcNow;
		}
	}
}
