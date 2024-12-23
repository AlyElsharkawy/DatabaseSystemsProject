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
	public partial class AddReading : Form
	{
		long courseID;
		long modID;
		public String readingTitle = "";
		public AddReading(long retrivedCourseID, long retrievedModID)
		{
			InitializeComponent();
			courseID = retrivedCourseID;
			modID = retrievedModID;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			readingTitle = titleTB.Text;
			String content = contentTb.Text;
			SubSectionsQueries.createReading(modID, courseID, readingTitle, content);
			Close();

		}
	}
}
