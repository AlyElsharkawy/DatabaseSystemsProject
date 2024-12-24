namespace DatabaseSystemsProject.UI.Instructor.Course.Creation
{
	partial class CreateCourse
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
			this.nameTB = new System.Windows.Forms.TextBox();
			this.descTB = new System.Windows.Forms.RichTextBox();
			this.priceTB = new System.Windows.Forms.TextBox();
			this.selectBTN = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pathLBL = new System.Windows.Forms.Label();
			this.modulesBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameTB
			// 
			this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.nameTB.Location = new System.Drawing.Point(181, 48);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(436, 29);
			this.nameTB.TabIndex = 0;
			// 
			// descTB
			// 
			this.descTB.Location = new System.Drawing.Point(181, 133);
			this.descTB.Name = "descTB";
			this.descTB.Size = new System.Drawing.Size(436, 168);
			this.descTB.TabIndex = 1;
			this.descTB.Text = "";
			// 
			// priceTB
			// 
			this.priceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.priceTB.Location = new System.Drawing.Point(181, 96);
			this.priceTB.MaxLength = 5;
			this.priceTB.Name = "priceTB";
			this.priceTB.Size = new System.Drawing.Size(150, 29);
			this.priceTB.TabIndex = 2;
			this.priceTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// selectBTN
			// 
			this.selectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.selectBTN.Location = new System.Drawing.Point(181, 327);
			this.selectBTN.Name = "selectBTN";
			this.selectBTN.Size = new System.Drawing.Size(150, 35);
			this.selectBTN.TabIndex = 3;
			this.selectBTN.Text = "Select Photo";
			this.selectBTN.UseVisualStyleBackColor = true;
			this.selectBTN.Click += new System.EventHandler(this.selectBTN_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(48, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Course Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(48, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Course Price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(5, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Course Description";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label4.Location = new System.Drawing.Point(5, 332);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Course Thumbinal";
			// 
			// pathLBL
			// 
			this.pathLBL.AutoSize = true;
			this.pathLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.pathLBL.Location = new System.Drawing.Point(352, 336);
			this.pathLBL.Name = "pathLBL";
			this.pathLBL.Size = new System.Drawing.Size(141, 20);
			this.pathLBL.TabIndex = 8;
			this.pathLBL.Text = "Path/To/Photo.png";
			// 
			// modulesBTN
			// 
			this.modulesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.modulesBTN.Location = new System.Drawing.Point(149, 403);
			this.modulesBTN.Name = "modulesBTN";
			this.modulesBTN.Size = new System.Drawing.Size(382, 35);
			this.modulesBTN.TabIndex = 9;
			this.modulesBTN.Text = "Upload And Start adding Modules";
			this.modulesBTN.UseVisualStyleBackColor = true;
			this.modulesBTN.Click += new System.EventHandler(this.modulesBTN_Click);
			// 
			// CreateCourse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 450);
			this.Controls.Add(this.modulesBTN);
			this.Controls.Add(this.pathLBL);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.selectBTN);
			this.Controls.Add(this.priceTB);
			this.Controls.Add(this.descTB);
			this.Controls.Add(this.nameTB);
			this.Name = "CreateCourse";
			this.Text = "CreateCourse";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.RichTextBox descTB;
		private System.Windows.Forms.TextBox priceTB;
		private System.Windows.Forms.Button selectBTN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label pathLBL;
		private System.Windows.Forms.Button modulesBTN;
	}
}