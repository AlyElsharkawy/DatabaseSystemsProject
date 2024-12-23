using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Models
{
	public class Video
	{
		public long Id { get; set; }
		public long modID { get; set; }
		public long courseID { get; set; }
		public String title { get; set; }
		public String filePath { get; set; }
	}
}
