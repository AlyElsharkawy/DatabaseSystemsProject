﻿namespace DatabaseSystemsProject.UI.Instructor.Course.Creation.Subsections
{
	partial class AddVideo
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
			this.titleTB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.videPathLBL = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.button1.Location = new System.Drawing.Point(95, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 33);
			this.button1.TabIndex = 11;
			this.button1.Text = "Select";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// titleTB
			// 
			this.titleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.titleTB.Location = new System.Drawing.Point(70, 12);
			this.titleTB.Name = "titleTB";
			this.titleTB.Size = new System.Drawing.Size(573, 32);
			this.titleTB.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 26);
			this.label2.TabIndex = 9;
			this.label2.Text = "Title";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(12, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 26);
			this.label1.TabIndex = 12;
			this.label1.Text = "Video";
			// 
			// videPathLBL
			// 
			this.videPathLBL.AutoSize = true;
			this.videPathLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.videPathLBL.Location = new System.Drawing.Point(236, 79);
			this.videPathLBL.Name = "videPathLBL";
			this.videPathLBL.Size = new System.Drawing.Size(149, 26);
			this.videPathLBL.TabIndex = 13;
			this.videPathLBL.Text = "Path/To/Video";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.button2.Location = new System.Drawing.Point(518, 156);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 33);
			this.button2.TabIndex = 14;
			this.button2.Text = "Submit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AddVideo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 205);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.videPathLBL);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.titleTB);
			this.Controls.Add(this.label2);
			this.Name = "AddVideo";
			this.Text = "AddVideo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox titleTB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label videPathLBL;
		private System.Windows.Forms.Button button2;
	}
}