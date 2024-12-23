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
	public partial class AddSAQ : Form
	{
		long courseID;
		long modID;
		public long secID = -1;
		public AddSAQ(long retrivedCourseID, long retrievedModID)
		{
			InitializeComponent();
			courseID = retrivedCourseID;
			modID = retrievedModID;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String content = promptTB.Text;
			byte grade = (byte)maxGrade.Value;
			secID = SubSectionsQueries.createSAQ(modID, courseID, content, grade);
			Close();

		}
	}
}
