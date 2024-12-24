namespace DatabaseSystemsProject.UI.Student.Courses
{
	partial class CourseEnroll
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseEnroll));
			this.nameLBL = new System.Windows.Forms.Label();
			this.thmubPB = new System.Windows.Forms.PictureBox();
			this.descLBL = new System.Windows.Forms.Label();
			this.enrollBTN = new System.Windows.Forms.Button();
			this.priceLBL = new System.Windows.Forms.Label();
			this.reviewsFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.thmubPB)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLBL
			// 
			this.nameLBL.AutoSize = true;
			this.nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLBL.Location = new System.Drawing.Point(12, 9);
			this.nameLBL.Name = "nameLBL";
			this.nameLBL.Size = new System.Drawing.Size(226, 37);
			this.nameLBL.TabIndex = 0;
			this.nameLBL.Text = "Course Name";
			// 
			// thmubPB
			// 
			this.thmubPB.Location = new System.Drawing.Point(19, 49);
			this.thmubPB.Name = "thmubPB";
			this.thmubPB.Size = new System.Drawing.Size(513, 219);
			this.thmubPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.thmubPB.TabIndex = 1;
			this.thmubPB.TabStop = false;
			// 
			// descLBL
			// 
			this.descLBL.AllowDrop = true;
			this.descLBL.AutoEllipsis = true;
			this.descLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.descLBL.Location = new System.Drawing.Point(552, 49);
			this.descLBL.Name = "descLBL";
			this.descLBL.Size = new System.Drawing.Size(226, 283);
			this.descLBL.TabIndex = 2;
			this.descLBL.Text = resources.GetString("descLBL.Text");
			// 
			// enrollBTN
			// 
			this.enrollBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.enrollBTN.Location = new System.Drawing.Point(672, 345);
			this.enrollBTN.Name = "enrollBTN";
			this.enrollBTN.Size = new System.Drawing.Size(96, 68);
			this.enrollBTN.TabIndex = 3;
			this.enrollBTN.Text = "Enroll";
			this.enrollBTN.UseVisualStyleBackColor = true;
			this.enrollBTN.Click += new System.EventHandler(this.enrollBTN_Click);
			// 
			// priceLBL
			// 
			this.priceLBL.AutoSize = true;
			this.priceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.priceLBL.Location = new System.Drawing.Point(552, 371);
			this.priceLBL.Name = "priceLBL";
			this.priceLBL.Size = new System.Drawing.Size(119, 20);
			this.priceLBL.TabIndex = 4;
			this.priceLBL.Text = "Price: 30000$";
			// 
			// reviewsFLP
			// 
			this.reviewsFLP.AutoScroll = true;
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
			// CourseEnroll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.reviewsFLP);
			this.Controls.Add(this.priceLBL);
			this.Controls.Add(this.enrollBTN);
			this.Controls.Add(this.descLBL);
			this.Controls.Add(this.thmubPB);
			this.Controls.Add(this.nameLBL);
			this.Name = "CourseEnroll";
			this.Text = "CourseEnroll";
			((System.ComponentModel.ISupportInitialize)(this.thmubPB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLBL;
		private System.Windows.Forms.PictureBox thmubPB;
		private System.Windows.Forms.Label descLBL;
		private System.Windows.Forms.Button enrollBTN;
		private System.Windows.Forms.Label priceLBL;
		private System.Windows.Forms.FlowLayoutPanel reviewsFLP;
		private System.Windows.Forms.Label label4;
	}
}