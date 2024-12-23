using DatabaseSystemsProject.UI.Instructor.Course.Creation;
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

namespace DatabaseSystemsProject.UI.Instructor
{
	public partial class HomeScreen : Form
	{
		String placeHolderPath;
		public HomeScreen()
		{
			InitializeComponent();
			placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "placeholder.png");
			loadDummyData();

		}

		private void loadDummyData()
		{
			var items = new[]
			{
				new { Name = "Item 1", Description = "Description 1", Thumbnail = placeHolderPath },
				new { Name = "Item 2", Description = "Description 2", Thumbnail = placeHolderPath },
				new { Name = "Item 3", Description = "Description 3", Thumbnail = placeHolderPath },
				new { Name = "Item 2", Description = "Description 2", Thumbnail = placeHolderPath },
				new { Name = "Item 2", Description = "Description 2", Thumbnail = placeHolderPath },
			};

			foreach (var item in items)
			{
				Panel coursePanel = new Panel { 
					Width = 500,
					Height = 100,
					Margin = new Padding(10),
					BorderStyle = BorderStyle.FixedSingle 
				};

				PictureBox courseThumb = new PictureBox
				{
					Image = Image.FromFile(item.Thumbnail), // Set thumbnail image
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

				Button courseBTN = new Button
				{
					Text = "Open",
					Location = new Point(410, 25),
					Width = 80,
					Height = 50
				};


				courseBTN.Click += (sender, e) => { MessageBox.Show($"You selected {item.Name}"); };

				coursePanel.Controls.Add(courseThumb);
				coursePanel.Controls.Add(courseName);
				coursePanel.Controls.Add(courseDesc);
				coursePanel.Controls.Add(courseBTN);

				CoursesFLP.Controls.Add(coursePanel);

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			new CreateCourse().ShowDialog();
		}
	}
}
