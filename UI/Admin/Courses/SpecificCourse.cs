using DatabaseSystemsProject.Models;
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

namespace DatabaseSystemsProject.UI.Admin.Courses
{
	public partial class SpecificCourse : Form
	{
		Course selectedCourse;
		public SpecificCourse(Course recievedCourse)
		{
            String placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "placeholder.png");
			selectedCourse = recievedCourse;
            InitializeComponent();
			courseName.Text = recievedCourse.Name;
			courseImage.Image = Image.FromFile(placeHolderPath);
			courseDescription.Text = recievedCourse.Description;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			new AllStudents(selectedCourse.Id).Show();
        }
    }
}
