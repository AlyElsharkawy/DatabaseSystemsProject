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

namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
	public partial class StudentsList : Form
	{
		String placeHolderPath;
		long courseID;
		public StudentsList(long courseID)
		{
			InitializeComponent();
			placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "personPlaceholder.jpg");
			this.courseID = courseID;
			loadDummyData();
		}

		private void loadDummyData()
		{
			var items = StudentQueries.getCourseStudents(courseID);

			foreach (var item in items)
			{
				Panel coursePanel = new Panel
				{
					Width = 755,
					Height = 100,
					Margin = new Padding(10),
					BorderStyle = BorderStyle.FixedSingle
				};

				PictureBox studentPfp = new PictureBox
				{
					Image = Image.FromFile(placeHolderPath), // Set thumbnail image
					SizeMode = PictureBoxSizeMode.StretchImage,
					Width = 80,
					Height = 80,
					Location = new Point(10, 10)
				};

				Label studentName = new Label
				{
					Text = item.name,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(100, 10),
					Width = 300
				};

				Label studentPno = new Label
				{
					Text = "Phone Number: " + item.pno,
					Location = new Point(100, 35),
					Width = 300
				};



				Label modulesProg = new Label
				{
					Text = $"Completed: {ModuleQueires.completedModules(courseID, item.Id)} ",
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(450, 25),
					Width = 200
				};
				//Button reviewBTN = new Button
				//{
				//	Text = "Write a review",
				//	
				//	Width = 80,
				//	Height = 50,
				//	Enabled = false
				//};

				Button assignBTN = new Button
				{
					Text = "View Work",
					Location = new Point(650, 25),
					Width = 80,
					Height = 50
				};


				assignBTN.Click += (sender, e) => { new StudentsWork(courseID, item.Id).ShowDialog(); };

				coursePanel.Controls.Add(studentPfp);
				coursePanel.Controls.Add(studentName);
				coursePanel.Controls.Add(studentPno);
				coursePanel.Controls.Add(assignBTN);
				coursePanel.Controls.Add(modulesProg);

				studentsFLP.Controls.Add(coursePanel);

			}
		}

	}
}
