using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Utility;
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

namespace DatabaseSystemsProject.UI.Admin
{
	public partial class AddAdmin : Form
	{
		public AddAdmin()
		{
			InitializeComponent();
		}

        String path;
        private void adminProfilePic_Click(object sender, EventArgs e)
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "";
        }

        private void registerAdmin_Click(object sender, EventArgs e)
        {
            String name = adminName.Text;
            String email = adminEmail.Text;
            DateTime dateTime = adminDoB.Value;
            String path = pfpPathLBL.Text;
            String pass = adminPassword.Text;
            String confirmPass = adminConfirmPassword.Text;
            String phoneNumber = adminPhoneNumber.Text;

            if (!pass.Equals(confirmPass))
            {
                return;
            }

            byte[] salt = PasswordEncryption.GenerateSalt();
            byte[] hash = PasswordEncryption.HashPassword(pass, salt);

            String saltHex = PasswordEncryption.ByteArrayToHexString(salt);
            String hashHex = PasswordEncryption.ByteArrayToHexString(hash);

            AdminQueries.registerAdmin(name, email, dateTime, path, phoneNumber, hashHex, saltHex);

            Close();
        }
    }
}
