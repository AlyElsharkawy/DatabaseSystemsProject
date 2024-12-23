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
	public partial class AddTFQ : Form
	{
		long courseID;
		long moduleID;
		public long tfqID = -1;
		public AddTFQ(long rcid,long rmid)
		{
			InitializeComponent();
			courseID = rcid;
			moduleID = rmid;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String prompt = promptTB.Text;
			byte grade = (byte)maxGrade.Value;
			byte correctOpt = getCorrectValue();

			tfqID = SubSectionsQueries.createTFQ(moduleID,courseID,prompt,grade,correctOpt);
			Close();
		}


		private byte getCorrectValue()
		{
			if (trueRB.Checked)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
