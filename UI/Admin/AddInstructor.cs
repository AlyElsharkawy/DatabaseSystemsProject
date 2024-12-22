using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Models;
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
	public partial class AddInstructor : Form
	{
		public AddInstructor()
		{
			InitializeComponent();
			Organization defaultOrg = new Organization
			{
				ID = -1,
				Name = "None"
			};
            var allOrgs = OrganisationQueries.getAllOrgs();
            allOrgs.Insert(0, defaultOrg);
			instructorOrganisation.DataSource = allOrgs;
            instructorOrganisation.DisplayMember = "Name";
            instructorOrganisation.ValueMember = "ID";
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registerInstructor_Click(object sender, EventArgs e)
        {
            String name = instructorName.Text;
            String email = instructoreEmail.Text;
            DateTime dateTime = instructorDateOfBirh.Value;
            String path = pfpPathLBL.Text;
            String pass = instructorPassword.Text;
            String confirmPass = instructorConfirmPassword.Text;
            String phoneNumber = instructorPhoneNumber.Text;
			Organization org = (Organization)instructorOrganisation.SelectedItem;
            long orgID = org.ID;

            if (!pass.Equals(confirmPass))
            {
                return;
            }

            byte[] salt = PasswordEncryption.GenerateSalt();
            byte[] hash = PasswordEncryption.HashPassword(pass, salt);

            String saltHex = PasswordEncryption.ByteArrayToHexString(salt);
            String hashHex = PasswordEncryption.ByteArrayToHexString(hash);

            InstructorQueries.registerInstructor(name, email, dateTime, path, phoneNumber, hashHex, saltHex , orgID);

            Close();
        }
    }
}
