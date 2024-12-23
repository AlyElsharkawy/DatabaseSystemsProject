namespace DatabaseSystemsProject.UI.Student.Courses
{
	partial class Certificate
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
            this.label1 = new System.Windows.Forms.Label();
            this.issueDate = new System.Windows.Forms.Label();
            this.expiryDate = new System.Windows.Forms.Label();
            this.certificateInfo = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(163, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "Congratulations!";
            // 
            // issueDate
            // 
            this.issueDate.AutoSize = true;
            this.issueDate.Location = new System.Drawing.Point(316, 263);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(54, 13);
            this.issueDate.TabIndex = 8;
            this.issueDate.Text = "issueDate";
            // 
            // expiryDate
            // 
            this.expiryDate.AutoSize = true;
            this.expiryDate.Location = new System.Drawing.Point(316, 289);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(57, 13);
            this.expiryDate.TabIndex = 9;
            this.expiryDate.Text = "expiryDate";
            // 
            // certificateInfo
            // 
            this.certificateInfo.AutoSize = true;
            this.certificateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certificateInfo.Location = new System.Drawing.Point(170, 214);
            this.certificateInfo.Name = "certificateInfo";
            this.certificateInfo.Size = new System.Drawing.Size(398, 24);
            this.certificateInfo.TabIndex = 12;
            this.certificateInfo.Text = "You have earned certificate name with a grade";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(313, 145);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(237, 31);
            this.studentName.TabIndex = 13;
            this.studentName.Text = "Mr, studentName";
            // 
            // Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 354);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.certificateInfo);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.label1);
            this.Name = "Certificate";
            this.Text = "Certificate";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label issueDate;
        private System.Windows.Forms.Label expiryDate;
        private System.Windows.Forms.Label certificateInfo;
        private System.Windows.Forms.Label studentName;
    }
}