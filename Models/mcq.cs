using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Models
{
	public class mcq
	{
		public long ID { get; set; }
		public long CourseID { get; set; }
		public long ModuleID { get; set; }
		public byte MaxGrade { get; set; }
		public string Prompt { get; set; }
		public byte CorrectAnswer { get; set; }
		public string QuestionOne { get; set; }
		public string QuestionTwo { get; set; }
		public string QuestionThree { get; set; }
		public string QuestionFour { get; set; }
	}
}
