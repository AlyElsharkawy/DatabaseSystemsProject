using DatabaseSystemsProject.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Instructor.Course.Creation.Subsections
{
	public partial class AddMCQ : Form
	{
		long courseID;
		long modID;
		public long mcqID = -1;
		public AddMCQ(long retrCourseID, long retrModID)
		{
			InitializeComponent();
			courseID = retrCourseID;
			modID = retrModID;
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void submitBTN_Click(object sender, EventArgs e)
		{
			String prompt = promptTB.Text;
			String opt1 = op1TB.Text;
			String opt2 = op2TB.Text;
			String opt3 = op3TB.Text;
			String opt4 = op4TB.Text;
			byte maxGrdae = (byte)maxGrade.Value;
			byte correctIndex = (byte)corOptIndex.Value;
			mcqID = SubSectionsQueries.createMCQ(modID,courseID,prompt,maxGrdae,correctIndex,opt1,opt2,opt3,opt4);
			Close();

		}
	}
}
