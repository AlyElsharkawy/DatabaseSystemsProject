using DatabaseSystemsProject.UI.Instructor;
using DatabaseSystemsProject.UI.Instructor.ManageStudent;
using DatabaseSystemsProject.UI.Student.Courses;
using DatabaseSystemsProject.UI.Student.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new StudentsList());
		}
	}
}
