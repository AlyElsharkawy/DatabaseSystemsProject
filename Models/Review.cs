using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Models
{
	public class Review
	{
		public long ID { get; set; }
		public long StudentID { get; set; }
		public long CourseID { get; set; }
		public string Title { get; set; }
		public string CONTENT { get; set; }
		public byte Rating { get; set; }
	}
}
