namespace DatabaseSystemsProject.UI.Admin.AllStudents
{
	partial class AllStudents
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
            this.stuPB = new System.Windows.Forms.PictureBox();
            this.stuNameLBL = new System.Windows.Forms.Label();
            this.stuPnoLBL = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stuPB)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsFLP
            // 
            this.studentsFLP.AutoScroll = true;
            this.studentsFLP.Dock = System.Windows.Forms.DockStyle.Left;
            this.studentsFLP.Location = new System.Drawing.Point(0, 0);
            this.studentsFLP.Name = "studentsFLP";
            this.studentsFLP.Size = new System.Drawing.Size(478, 450);
            this.studentsFLP.TabIndex = 0;
            // 
            // stuPB
            // 
            this.stuPB.Location = new System.Drawing.Point(579, 12);
            this.stuPB.Name = "stuPB";
            this.stuPB.Size = new System.Drawing.Size(107, 102);
            this.stuPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stuPB.TabIndex = 0;
            this.stuPB.TabStop = false;
            // 
            // stuNameLBL
            // 
            this.stuNameLBL.AutoSize = true;
            this.stuNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.stuNameLBL.Location = new System.Drawing.Point(498, 143);
            this.stuNameLBL.Name = "stuNameLBL";
            this.stuNameLBL.Size = new System.Drawing.Size(0, 24);
            this.stuNameLBL.TabIndex = 1;
            // 
            // stuPnoLBL
            // 
            this.stuPnoLBL.AutoSize = true;
            this.stuPnoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.stuPnoLBL.Location = new System.Drawing.Point(498, 192);
            this.stuPnoLBL.Name = "stuPnoLBL";
            this.stuPnoLBL.Size = new System.Drawing.Size(0, 24);
            this.stuPnoLBL.TabIndex = 2;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.emailLbl.Location = new System.Drawing.Point(498, 247);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(0, 24);
            this.emailLbl.TabIndex = 3;
            // 
            // AllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.stuPnoLBL);
            this.Controls.Add(this.stuNameLBL);
            this.Controls.Add(this.stuPB);
            this.Controls.Add(this.studentsFLP);
            this.Name = "AllStudents";
            this.Text = "StudentsList";
            ((System.ComponentModel.ISupportInitialize)(this.stuPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel studentsFLP;
		private System.Windows.Forms.PictureBox stuPB;
		private System.Windows.Forms.Label stuNameLBL;
		private System.Windows.Forms.Label stuPnoLBL;
        private System.Windows.Forms.Label emailLbl;
    }
}