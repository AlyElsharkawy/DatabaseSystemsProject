using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Models
{
	public class Assignment
	{
		public long ID { get; set; }
		public long ModuleID { get; set; }
		public long CourseID { get; set; }
		public string Prompt { get; set; }
		public byte MaxGrade { get; set; }
	}
}
