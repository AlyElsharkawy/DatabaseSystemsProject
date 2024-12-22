using DatabaseSystemsProject.Models;
using DatabaseSystemsProject.UI.Student.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class CoursePay : Form
	{
		public CoursePay(Course selectedCourse)
		{
			InitializeComponent();
			nameLBL.Text = selectedCourse.Name;
			priceLBL.Text = "Price: " + selectedCourse.price.ToString() + "$";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			new AllCards().ShowDialog();
		}
	}
}
