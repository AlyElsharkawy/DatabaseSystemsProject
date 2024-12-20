using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Auth
{
	public partial class RegisterScreen : Form
	{
		public RegisterScreen()
		{
			InitializeComponent();
		}

		private void selectPfpBTN_Click(object sender, EventArgs e)
		{
			String path = getPfpPath();
			if (!String.IsNullOrEmpty(path))
			{
				pfpPathLBL.Text = path;
			}
		}


		private String getPfpPath()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				return openFileDialog.FileName;
			}
			return "";
		}
	}
}
