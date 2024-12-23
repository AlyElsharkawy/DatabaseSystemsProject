namespace DatabaseSystemsProject.UI.Admin
{
	partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.coursesList = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.Button();
            this.addAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(12, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Instructor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(12, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Organization";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // coursesList
            // 
            this.coursesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.coursesList.Location = new System.Drawing.Point(12, 212);
            this.coursesList.Name = "coursesList";
            this.coursesList.Size = new System.Drawing.Size(303, 38);
            this.coursesList.TabIndex = 6;
            this.coursesList.Text = "Courses List";
            this.coursesList.UseVisualStyleBackColor = true;
            this.coursesList.Click += new System.EventHandler(this.coursesList_Click);
            // 
            // studentList
            // 
            this.studentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.studentList.Location = new System.Drawing.Point(12, 256);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(303, 38);
            this.studentList.TabIndex = 7;
            this.studentList.Text = "Students List";
            this.studentList.UseVisualStyleBackColor = true;
            this.studentList.Click += new System.EventHandler(this.studentList_Click);
            // 
            // addAdmin
            // 
            this.addAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addAdmin.Location = new System.Drawing.Point(12, 80);
            this.addAdmin.Name = "addAdmin";
            this.addAdmin.Size = new System.Drawing.Size(303, 38);
            this.addAdmin.TabIndex = 8;
            this.addAdmin.Text = "Add Admin";
            this.addAdmin.UseVisualStyleBackColor = true;
            this.addAdmin.Click += new System.EventHandler(this.addAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAdmin);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.coursesList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button coursesList;
		private System.Windows.Forms.Button studentList;
		private System.Windows.Forms.Button addAdmin;
		private System.Windows.Forms.Label label1;
	}
}