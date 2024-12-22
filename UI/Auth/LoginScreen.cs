using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.UI.Auth;
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
			long studentID = StudentQueries.loginStudent(emailTB.Text, passTB.Text);
			if(studentID <= -1)
			{
				MessageBox.Show("Failed login");
			}
			else
			{
				new HomeScreen().Show();
			}
		}
	}
}
