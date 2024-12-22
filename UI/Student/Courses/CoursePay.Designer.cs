namespace DatabaseSystemsProject.UI.Student.Courses
{
	partial class CoursePay
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
			this.priceLBL = new System.Windows.Forms.Label();
			this.confirmPurcBTN = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.usedCardLBL = new System.Windows.Forms.Label();
			this.nameLBL = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// priceLBL
			// 
			this.priceLBL.AutoSize = true;
			this.priceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.priceLBL.Location = new System.Drawing.Point(76, 93);
			this.priceLBL.Name = "priceLBL";
			this.priceLBL.Size = new System.Drawing.Size(146, 25);
			this.priceLBL.TabIndex = 5;
			this.priceLBL.Text = "Price: 30000$";
			// 
			// confirmPurcBTN
			// 
			this.confirmPurcBTN.Enabled = false;
			this.confirmPurcBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPurcBTN.Location = new System.Drawing.Point(43, 221);
			this.confirmPurcBTN.Name = "confirmPurcBTN";
			this.confirmPurcBTN.Size = new System.Drawing.Size(219, 32);
			this.confirmPurcBTN.TabIndex = 6;
			this.confirmPurcBTN.Text = "Confirm Purchase";
			this.confirmPurcBTN.UseVisualStyleBackColor = true;
			this.confirmPurcBTN.Click += new System.EventHandler(this.confirmPurcBTN_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button2.Location = new System.Drawing.Point(65, 121);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(173, 39);
			this.button2.TabIndex = 7;
			this.button2.Text = "Select bank card";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// usedCardLBL
			// 
			this.usedCardLBL.AutoSize = true;
			this.usedCardLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.usedCardLBL.Location = new System.Drawing.Point(60, 163);
			this.usedCardLBL.Name = "usedCardLBL";
			this.usedCardLBL.Size = new System.Drawing.Size(184, 26);
			this.usedCardLBL.TabIndex = 8;
			this.usedCardLBL.Text = "No Card Selected";
			// 
			// nameLBL
			// 
			this.nameLBL.AutoEllipsis = true;
			this.nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLBL.Location = new System.Drawing.Point(12, 9);
			this.nameLBL.Name = "nameLBL";
			this.nameLBL.Size = new System.Drawing.Size(288, 84);
			this.nameLBL.TabIndex = 9;
			this.nameLBL.Text = "Course Name";
			this.nameLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CoursePay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 263);
			this.Controls.Add(this.nameLBL);
			this.Controls.Add(this.usedCardLBL);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.confirmPurcBTN);
			this.Controls.Add(this.priceLBL);
			this.Name = "CoursePay";
			this.Text = "CoursePay";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label priceLBL;
		private System.Windows.Forms.Button confirmPurcBTN;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label usedCardLBL;
		private System.Windows.Forms.Label nameLBL;
	}
}