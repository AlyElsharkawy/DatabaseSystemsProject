using DatabaseSystemsProject.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Instructor.Course.Creation.Subsections
{
	public partial class AddVideo : Form
	{

		String path;
		long moduleID;
		long courseid;
		public String videoTitle;
		public AddVideo(long courseID, long modID)
		{
			InitializeComponent();
			courseid = courseID;
			moduleID = modID;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			videoTitle = titleTB.Text;
			SubSectionsQueries.createVideo(moduleID, courseid, videoTitle, path);
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			path = getPfpPath();
			if (!String.IsNullOrEmpty(path))
			{
				videPathLBL.Text = path;
			}
		}

		private String getPfpPath()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				return openFileDialog.FileName;
			}
			return "";
		}
	}
}
