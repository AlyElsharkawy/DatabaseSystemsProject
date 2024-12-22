namespace DatabaseSystemsProject.UI.Admin.Courses
{
	partial class SpecificCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecificCourse));
            this.label4 = new System.Windows.Forms.Label();
            this.reviewsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.courseDescription = new System.Windows.Forms.Label();
            this.courseImage = new System.Windows.Forms.PictureBox();
            this.courseName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reviews";
            // 
            // reviewsFLP
            // 
            this.reviewsFLP.Location = new System.Drawing.Point(24, 309);
            this.reviewsFLP.Name = "reviewsFLP";
            this.reviewsFLP.Size = new System.Drawing.Size(513, 131);
            this.reviewsFLP.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(561, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "Students List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // courseDescription
            // 
            this.courseDescription.AllowDrop = true;
            this.courseDescription.AutoEllipsis = true;
            this.courseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseDescription.Location = new System.Drawing.Point(557, 51);
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Size = new System.Drawing.Size(226, 283);
            this.courseDescription.TabIndex = 9;
            this.courseDescription.Text = resources.GetString("courseDescription.Text");
            // 
            // courseImage
            // 
            this.courseImage.Location = new System.Drawing.Point(24, 51);
            this.courseImage.Name = "courseImage";
            this.courseImage.Size = new System.Drawing.Size(513, 219);
            this.courseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.courseImage.TabIndex = 8;
            this.courseImage.TabStop = false;
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.Location = new System.Drawing.Point(17, 11);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(226, 37);
            this.courseName.TabIndex = 7;
            this.courseName.Text = "Course Name";
            // 
            // SpecificCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reviewsFLP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseDescription);
            this.Controls.Add(this.courseImage);
            this.Controls.Add(this.courseName);
            this.Name = "SpecificCourse";
            this.Text = "SpecificCourse";
            ((System.ComponentModel.ISupportInitialize)(this.courseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.FlowLayoutPanel reviewsFLP;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label courseDescription;
		private System.Windows.Forms.PictureBox courseImage;
		private System.Windows.Forms.Label courseName;
	}
}