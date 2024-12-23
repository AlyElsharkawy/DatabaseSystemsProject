namespace DatabaseSystemsProject.UI.Instructor
{
	partial class InstructorScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.totalStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesFLP
            // 
            this.CoursesFLP.AutoScroll = true;
            this.CoursesFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoursesFLP.Location = new System.Drawing.Point(12, 12);
            this.CoursesFLP.Name = "CoursesFLP";
            this.CoursesFLP.Size = new System.Drawing.Size(554, 426);
            this.CoursesFLP.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseSystemsProject.Properties.Resources.personPlaceholder;
            this.pictureBox1.Location = new System.Drawing.Point(627, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Create Course";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // totalStudent
            // 
            this.totalStudent.AutoSize = true;
            this.totalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalStudent.Location = new System.Drawing.Point(569, 135);
            this.totalStudent.Name = "totalStudent";
            this.totalStudent.Size = new System.Drawing.Size(209, 17);
            this.totalStudent.TabIndex = 5;
            this.totalStudent.Text = "Total Registered Students:3000";
            // 
            // InstructorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalStudent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CoursesFLP);
            this.Name = "InstructorScreen";
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel CoursesFLP;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label totalStudent;
	}
}