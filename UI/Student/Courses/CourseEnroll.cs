﻿using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Models;
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

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class CourseEnroll : Form
	{
		Course selectedCoruse;
		public CourseEnroll(Course recieved)
		{
			selectedCoruse = recieved;
			InitializeComponent();
			String placeHolderPath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "assets", "placeholder.png");
			nameLBL.Text = selectedCoruse.Name;
			descLBL.Text = selectedCoruse.Description;
			thmubPB.Image = Image.FromFile(placeHolderPath);
			priceLBL.Text = "Price: " + selectedCoruse.price.ToString() + "$";
			loadReviews(recieved.Id);
		}

		private void enrollBTN_Click(object sender, EventArgs e)
		{
			var pay = new CoursePay(selectedCoruse);
			pay.ShowDialog();
			if (pay.closePrev)
			{
				Close();
			}
			
		}


		private void loadReviews(long courseID)
		{
			List<Review> reviews = CourseQueries.getCourseReviews(courseID);
			foreach (Review review in reviews) { 
			createReview(review);
			}
		}

		private void createReview(Review review) {

			Panel reviewPanel = new Panel();
			reviewPanel.Size = new Size(450, 120);
			reviewPanel.Margin = new Padding(5);
			reviewPanel.BorderStyle = BorderStyle.FixedSingle;

			Label titleLabel = new Label();
			titleLabel.Text = $"{review.Title}";
			titleLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			titleLabel.AutoSize = true;
			titleLabel.Location = new Point(5, 5);
			reviewPanel.Controls.Add(titleLabel);

			Label contentLabel = new Label();
			contentLabel.Text = $"{review.CONTENT}";
			contentLabel.Font = new Font("Arial", 9, FontStyle.Regular);
			contentLabel.Size = new Size(410, 60); 
			contentLabel.Location = new Point(5, 30);
			contentLabel.AutoEllipsis = true; 
			reviewPanel.Controls.Add(contentLabel);

			Label ratingLabel = new Label();
			ratingLabel.Text = $"{review.Rating}/10";
			ratingLabel.Font = new Font("Arial", 9, FontStyle.Regular);
			ratingLabel.AutoSize = true;
			ratingLabel.Location = new Point(5, 95);
			reviewPanel.Controls.Add(ratingLabel);

			reviewsFLP.Controls.Add(reviewPanel);
		}
	}
}
