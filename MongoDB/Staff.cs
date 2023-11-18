using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
	internal class Staff
	{
		public int id { get; set; } = 0;
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string position { get; set; }
		public string department { get; set; }
		public string email { get; set; }
		public string phone { get; set; }

		public Staff(int id, string firstName, string lastName, string position, string department, string email, string phone)
		{
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
			this.position = position;
			this.department = department;
			this.email = email;
			this.phone = phone;
		}

	}
}
