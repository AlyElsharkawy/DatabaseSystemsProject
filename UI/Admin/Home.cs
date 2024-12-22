using DatabaseSystemsProject.UI.Admin;
using DatabaseSystemsProject.UI.Admin.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Admin
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void Home_Load(object sender, EventArgs e)
		{

		}

        private void studentList_Click(object sender, EventArgs e)
        {
			new AllStudents().Show();
        }

        private void coursesList_Click(object sender, EventArgs e)
        {
			new AllCourses().ShowDialog();
        }
    }
}
