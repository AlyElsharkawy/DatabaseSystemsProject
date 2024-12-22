using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Models
{
	public class Course
	{
		public long Id { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
		public decimal price { get; set; }
		public String thumbPath { get; set; }
	}
}
