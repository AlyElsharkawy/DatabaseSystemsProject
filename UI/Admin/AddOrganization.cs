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

namespace DatabaseSystemsProject.UI.Admin
{
	public partial class AddOrganization : Form
	{
        long adminID;
		public AddOrganization(long adminID)
		{
			InitializeComponent();
            this.adminID = adminID;
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

        private void registerOrganisation_Click(object sender, EventArgs e)
        {
            String name = organisationName.Text;
            String desc = organisationDescription.Text;
            String path = pfpPathLBL.Text;

            OrganisationQueries.registerOrganisation(name, desc, path, adminID);

            Close();
        }
    }
}
