using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.UI.Admin;
using DatabaseSystemsProject.UI.Auth;
using DatabaseSystemsProject.UI.Instructor;
using DatabaseSystemsProject.UI.Student;
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

namespace DatabaseSystemsProject
{
	public partial class LoginScreen : Form
	{
		public LoginScreen()
		{
			InitializeComponent();
			
		}

		private void registerBTN_Click(object sender, EventArgs e)
		{
			new RegisterScreen().ShowDialog();
		}

		private void loginBTN_Click(object sender, EventArgs e)
		{
			int type = LoginQueries.type(emailTB.Text);

			long id = LoginQueries.authenticate(type, emailTB.Text, passTB.Text);
			if (id == -1)
			{
				MessageBox.Show("Login failed.");
				return;
			}

			switch (type)
			{
				case 1:
					new HomeScreen(id).ShowDialog();
					break;
				case 2:
					new Home(id).ShowDialog();
					break;
				case 3:
					new InstructorScreen(id).ShowDialog();
					break;
				default:
                    MessageBox.Show("Login failed.");
					break;
            }
		}
	}
}
