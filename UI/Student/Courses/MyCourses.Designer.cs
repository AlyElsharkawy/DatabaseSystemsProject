namespace DatabaseSystemsProject.UI.Student.Courses
{
	partial class MyCourses
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CoursesFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// CoursesFLP
			// 
			this.CoursesFLP.AutoScroll = true;
			this.CoursesFLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CoursesFLP.Location = new System.Drawing.Point(0, 0);
			this.CoursesFLP.Name = "CoursesFLP";
			this.CoursesFLP.Size = new System.Drawing.Size(800, 450);
			this.CoursesFLP.TabIndex = 0;
			// 
			// MyCourses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CoursesFLP);
			this.Name = "MyCourses";
			this.Text = "MyCourses";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel CoursesFLP;
	}
}