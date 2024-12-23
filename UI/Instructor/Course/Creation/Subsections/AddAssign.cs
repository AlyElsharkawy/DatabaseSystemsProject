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
	public partial class AddAssign : Form
	{
		long courseID;
		long moduleID;
		public long asignID = -1;
		public AddAssign(long courseID, long moduleID)
		{
			InitializeComponent();
			this.courseID = courseID;
			this.moduleID = moduleID;
		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String prompt = pormptTB.Text; ;
			byte grade = (byte)maxGrade.Value;
			asignID = SubSectionsQueries.createAssignemnt(moduleID,courseID,prompt,grade);
			Close();

		}
	}
}
