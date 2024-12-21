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
		public StudentsList()
		{
			InitializeComponent();
			placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "personPlaceholder.jpg");
			loadDummyData();
		}

		private void loadDummyData()
		{
			var items = new[]
			{
				new { Name = "Belal Salem", Description = "01501106719",CompletedModules= 3, Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719",CompletedModules= 3, Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719",CompletedModules= 3, Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719",CompletedModules= 3, Thumbnail = placeHolderPath },
				new { Name = "Belal Salem", Description = "01501106719",CompletedModules= 3, Thumbnail = placeHolderPath },
			};

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
					Width = 300
				};

				Label studentPno = new Label
				{
					Text = "Phone Number: " + item.Description,
					Location = new Point(100, 35),
					Width = 300
				};



				Label modulesProg = new Label
				{
					Text = $"Completed: {item.CompletedModules}/6 ",
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


				assignBTN.Click += (sender, e) => { MessageBox.Show($"You selected {item.Name}"); };

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
