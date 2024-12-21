namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
	partial class StudentsList
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
			this.studentsFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// studentsFLP
			// 
			this.studentsFLP.AutoScroll = true;
			this.studentsFLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.studentsFLP.Location = new System.Drawing.Point(0, 0);
			this.studentsFLP.Name = "studentsFLP";
			this.studentsFLP.Size = new System.Drawing.Size(800, 450);
			this.studentsFLP.TabIndex = 0;
			// 
			// StudentsList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.studentsFLP);
			this.Name = "StudentsList";
			this.Text = "StudentsList";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel studentsFLP;
	}
}