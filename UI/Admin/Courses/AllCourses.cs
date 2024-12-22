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

namespace DatabaseSystemsProject.UI.Admin.Courses

{
	public partial class AllCourses : Form
	{

		String placeHolderPath;
		public AllCourses()
		{
			InitializeComponent();
			placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "placeholder.png");
			loadDummyData();
		}

		private void loadDummyData()
		{
			var items = CourseQueries.getAllCourses();

			foreach (var item in items)
			{
				Panel coursePanel = new Panel
				{
					Width = 755,
					Height = 100,
					Margin = new Padding(10),
					BorderStyle = BorderStyle.FixedSingle
				};

				PictureBox courseThumb = new PictureBox
				{
					Image = Image.FromFile(placeHolderPath), // Set thumbnail image
					SizeMode = PictureBoxSizeMode.StretchImage,
					Width = 80,
					Height = 80,
					Location = new Point(10, 10)
				};

				Label courseName = new Label
				{
					Text = item.Name,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(100, 10),
					Width = 300
				};

				Label courseDesc = new Label
				{
					Text = item.Description,
					Location = new Point(100, 35),
					Width = 300
				};

				Button enterBTN = new Button
				{
					Text = "Enter",
					Location = new Point(650, 25),
					Width = 80,
					Height = 50
				};


				enterBTN.Click += (sender, e) => { new SpecificCourse(item).ShowDialog(); };

				coursePanel.Controls.Add(courseThumb);
				coursePanel.Controls.Add(courseName);
				coursePanel.Controls.Add(courseDesc);
				coursePanel.Controls.Add(enterBTN);

				CoursesFLP.Controls.Add(coursePanel);

			}
		}

	}
}
