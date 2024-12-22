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

namespace DatabaseSystemsProject.UI.Admin.Courses.CourseStuList
{
	public partial class CourseStuList : Form
	{
		String placeHolderPath;
		public CourseStuList()
		{
			InitializeComponent();
			placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "personPlaceholder.jpg");
			loadDummyData();
		}

		private void loadDummyData()
		{
			var items = new[]
			{
				new { Name = "Belal Salem", Description = "01501106719", Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719", Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719", Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719", Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719" ,Thumbnail = placeHolderPath },
			};

			foreach (var item in items)
			{
				Panel coursePanel = new Panel
				{
					Width = 450,
					Height = 100,
					Margin = new Padding(10),
					BorderStyle = BorderStyle.FixedSingle
				};

				PictureBox studentPfp = new PictureBox
				{
					Image = Image.FromFile(item.Thumbnail), // Set thumbnail image
					SizeMode = PictureBoxSizeMode.StretchImage,
					Width = 80,
					Height = 80,
					Location = new Point(10, 10)
				};

				Label studentName = new Label
				{
					Text = item.Name,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(100, 10),
					Width = 250
				};

				Label studentPno = new Label
				{
					Text = "Phone Number: " + item.Description,
					Location = new Point(100, 35),
					Width = 150
				};

				Button viewBTN = new Button
				{
					Text = "View Details",
					Location = new Point(350, 25),
					Width = 80,
					Height = 50
				};


				viewBTN.Click += (sender, e) => { loadStudentData(item.Name,item.Description,item.Thumbnail); };

				coursePanel.Controls.Add(studentPfp);
				coursePanel.Controls.Add(studentName);
				coursePanel.Controls.Add(studentPno);
				coursePanel.Controls.Add(viewBTN);
				studentsFLP.Controls.Add(coursePanel);

			}
		}



		void loadStudentData(String name,String pno, String pfpPath)
		{
			stuPB.Image = Image.FromFile(pfpPath);
			stuNameLBL.Text = "Name: " + name;
			stuPnoLBL.Text = "Phone number: " + pno;
		}

	}
}
