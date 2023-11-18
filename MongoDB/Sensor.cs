using MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Lab3KM
{
	internal class Sensor
	{
		public int id { get; set; }
		public List<Data> datas { get; set; } = new List<Data>();

		public Sensor(int id)
		{
			this.id = id;
		}
	}
}
