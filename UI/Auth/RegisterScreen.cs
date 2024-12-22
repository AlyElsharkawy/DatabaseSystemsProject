using DatabaseSystemsProject.Utility;
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

		String path;

		private void selectPfpBTN_Click(object sender, EventArgs e)
		{
			path = getPfpPath();
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

		private void regBTN_Click(object sender, EventArgs e)
		{
			String name = nameTB.Text;
			String email = emailTB.Text;
			DateTime birthDate = dob.Value;
			String pass = passTB.Text;
			String confirmPass = confirmPassTB.Text;
			String phoneNumber = pnoTB.Text;

			if (!pass.Equals(confirmPass)) {
				return;
			}

			byte[] salt = PasswordEncryption.GenerateSalt();
			byte[] hash = PasswordEncryption.HashPassword(pass, salt);

			String saltHex = PasswordEncryption.ByteArrayToHexString(salt);
			String hashHex = PasswordEncryption.ByteArrayToHexString(hash);

			Database.registerStudent(name, email, birthDate,path, phoneNumber, hashHex, saltHex);

			Close();

		}
	}
}
