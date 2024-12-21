namespace DatabaseSystemsProject.UI.Instructor.Course
{
	partial class CourseView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseView));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.reviewsFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Course Name";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(19, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(513, 219);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoEllipsis = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(552, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 283);
			this.label2.TabIndex = 2;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.button1.Location = new System.Drawing.Point(556, 307);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(222, 38);
			this.button1.TabIndex = 3;
			this.button1.Text = "Students List";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// reviewsFLP
			// 
			this.reviewsFLP.Location = new System.Drawing.Point(19, 307);
			this.reviewsFLP.Name = "reviewsFLP";
			this.reviewsFLP.Size = new System.Drawing.Size(513, 131);
			this.reviewsFLP.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(14, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "Reviews";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.button2.Location = new System.Drawing.Point(556, 351);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(222, 38);
			this.button2.TabIndex = 7;
			this.button2.Text = "Assignments";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// CourseEnroll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.reviewsFLP);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "CourseEnroll";
			this.Text = "CourseEnroll";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FlowLayoutPanel reviewsFLP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
	}
}