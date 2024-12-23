using DatabaseSystemsProject.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Instructor.Course.Creation
{
	public partial class CreateModule : Form
	{
		public long moduleID = -1;
		long courseID;
		public String moduleName;
		public CreateModule(long retrievedID)
		{
			InitializeComponent();
			courseID = retrievedID;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			moduleName = modNameTB.Text;
			moduleID = ModuleQueires.CreateModule(courseID, moduleName);
			Close();

		}
	}
}
