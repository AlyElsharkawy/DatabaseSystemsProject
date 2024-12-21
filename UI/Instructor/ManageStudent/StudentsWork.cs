using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
	public partial class StudentsWork : Form
	{
		public StudentsWork()
		{
			InitializeComponent();
			loadDummyData();
		}
		private void loadDummyData()
		{
			var items = new[]
			{
				new { Name = "Assignment", Description = "Module 1",Grade = 10},
				new { Name = "MCQ", Description = "Module 2",Grade= 2 },
				new { Name = "T/F", Description = "Module 1",Grade= 3 },
				new { Name = "Short Answer", Description = "Module 5",Grade= 3 },
				new { Name = "Belal Salem", Description = "Module 8",Grade= 3 },
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

				Label qType = new Label
				{
					Text = item.Name,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(10, 10),
					Width = 300
				};

				Label qModule = new Label
				{
					Text = item.Description,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(150, 10),
					Width = 250
				};

				Label qGrade = new Label
				{
					Text = $"Grade: {item.Grade}/10",
					Location = new Point(300, 10),
					Width = 300
				};

				//Button reviewBTN = new Button
				//{
				//	Text = "Write a review",
				//	
				//	Width = 80,
				//	Height = 50,
				//	Enabled = false
				//};

				Button gradeBTN = new Button
				{
					Text = "Grade Work",
					Location = new Point(650, 25),
					Width = 80,
					Height = 50
				};


				gradeBTN.Click += (sender, e) => { MessageBox.Show($"You selected {item.Name}"); };

				coursePanel.Controls.Add(qGrade);
				coursePanel.Controls.Add(qModule);
				coursePanel.Controls.Add(qType);
				coursePanel.Controls.Add(gradeBTN);

				workFLP.Controls.Add(coursePanel);

			}
		}

	}
}
