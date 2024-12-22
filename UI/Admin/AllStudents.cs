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

namespace DatabaseSystemsProject.UI.Admin
{
	public partial class AllStudents : Form
	{
		String placeHolderPath;
		public AllStudents()
		{
			InitializeComponent();
			placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "personPlaceholder.jpg");
			loadDummyData();
		}

		private void loadDummyData()
		{
			var items = StudentQueries.getAllStudents();

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
					Location = new Point(100, 35),
					Width = 250
				};


				Button viewBTN = new Button
				{
					Text = "View Details",
					Location = new Point(350, 25),
					Width = 80,
					Height = 50
				};


				viewBTN.Click += (sender, e) => { loadStudentData(item.name,item.pno,item.email); };

				coursePanel.Controls.Add(studentPfp);
				coursePanel.Controls.Add(studentName);
				coursePanel.Controls.Add(viewBTN);
				studentsFLP.Controls.Add(coursePanel);

			}
		}



		void loadStudentData(String name,String pno, String email)
		{
			stuPB.Image = Image.FromFile(placeHolderPath);
			stuNameLBL.Text = "Name: " + name;
			stuPnoLBL.Text = "Phone number: " + pno;
			emailLbl.Text = "Email: " + email;
		}

	}
}
