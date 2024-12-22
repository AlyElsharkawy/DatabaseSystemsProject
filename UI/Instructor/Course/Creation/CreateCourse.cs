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

namespace DatabaseSystemsProject.UI.Instructor.Course.Creation
{
	public partial class CreateCourse : Form
	{
		public CreateCourse()
		{
			InitializeComponent();
		}

		static long currentID = -1;

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		static String path;

		private void selectBTN_Click(object sender, EventArgs e)
		{
			path = getPfpPath();
			if (!String.IsNullOrEmpty(path))
			{
				pathLBL.Text = path;
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

		private void modulesBTN_Click(object sender, EventArgs e)
		{
			String name = nameTB.Text;
			String desc = descTB.Text;
			try
			{
				double price = double.Parse(priceTB.Text);
				currentID = CourseQueries.CreateCourse(name, price, path, desc);
			}
			catch
			{
				currentID = -1;
			}
			
			if(currentID <= -1)
			{
				MessageBox.Show("error");
				return;
			}
			new ModulesEdit(currentID).ShowDialog();
		}
	}
}
