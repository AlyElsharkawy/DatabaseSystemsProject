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

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class CourseEnroll : Form
	{
		Course selectedCoruse;
		public CourseEnroll(Course recieved)
		{
			selectedCoruse = recieved;
			InitializeComponent();
			String placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "placeholder.png");
			nameLBL.Text = selectedCoruse.Name;
			descLBL.Text = selectedCoruse.Description;
			thmubPB.Image = Image.FromFile(placeHolderPath);
			priceLBL.Text = "Price: " + selectedCoruse.price.ToString() + "$";
		}

		private void enrollBTN_Click(object sender, EventArgs e)
		{
			new CoursePay(selectedCoruse).ShowDialog();
		}
	}
}
