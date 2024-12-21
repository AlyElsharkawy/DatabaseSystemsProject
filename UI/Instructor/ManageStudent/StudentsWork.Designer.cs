namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
	partial class StudentsWork
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
			this.workFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// workFLP
			// 
			this.workFLP.AutoScroll = true;
			this.workFLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.workFLP.Location = new System.Drawing.Point(0, 0);
			this.workFLP.Name = "workFLP";
			this.workFLP.Size = new System.Drawing.Size(800, 450);
			this.workFLP.TabIndex = 0;
			// 
			// StudentsWork
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.workFLP);
			this.Name = "StudentsWork";
			this.Text = "StudentsWork";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel workFLP;
	}
}