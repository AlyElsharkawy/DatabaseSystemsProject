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

namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
	public partial class StudentsWork : Form
	{
		long courseID, studentID;
		public StudentsWork(long courseID, long studentID)
		{
			InitializeComponent();
			this.courseID = courseID;	
			this.studentID = studentID;	

			loadDummyData();
		}
		private void loadDummyData()
		{
            // SA
            var sas = SubSectionsQueries.sAQSolved(courseID, studentID);

            foreach (var item in sas)
            {
                if(item.Grade != null)
                {
                    continue;
                }
                
                Panel coursePanel = new Panel
                {
                    Width = 755,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label qType = new Label
                {
                    Text =  "ShortAnswer" + item.ID.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    Width = 300
                };

                Label qModule = new Label
                {
                    Text = item.ModuleTitle,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(150, 10),
                    Width = 250
                };

                Label qGrade = new Label
                {
                    Text = item.SolvedDate.ToString(),
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


                gradeBTN.Click += (sender, e) => { new StudentsGrade(studentID, item.ID).ShowDialog(); workFLP.Controls.Clear(); loadDummyData(); };

                coursePanel.Controls.Add(qGrade);
                coursePanel.Controls.Add(qModule);
                coursePanel.Controls.Add(qType);
                coursePanel.Controls.Add(gradeBTN);

                workFLP.Controls.Add(coursePanel);

            }

            // Assignments

            var assignments = SubSectionsQueries.assignSolved(courseID, studentID);

            foreach (var item in assignments)
            {
                if(item.Grade != null)
                {
                    continue;
                }
                Panel coursePanel = new Panel
                {
                    Width = 755,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label qType = new Label
                {
                    Text = "Assignment" + item.ID.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    Width = 300
                };

                Label qModule = new Label
                {
                    Text = item.ModuleTitle,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(150, 10),
                    Width = 250
                };

                Label qGrade = new Label
                {
                    Text = item.SolvedDate.ToString(),
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


                gradeBTN.Click += (sender, e) => { new StudentsGradeAssignment(studentID, item.ID).ShowDialog(); workFLP.Controls.Clear(); loadDummyData(); };

                coursePanel.Controls.Add(qGrade);
                coursePanel.Controls.Add(qModule);
                coursePanel.Controls.Add(qType);
                coursePanel.Controls.Add(gradeBTN);

                workFLP.Controls.Add(coursePanel);

            }




        }

	}
}
