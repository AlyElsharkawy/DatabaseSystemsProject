namespace DatabaseSystemsProject.UI.Auth
{
	partial class RegisterScreen
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
			this.emailTB = new System.Windows.Forms.TextBox();
			this.nameTB = new System.Windows.Forms.MaskedTextBox();
			this.dob = new System.Windows.Forms.DateTimePicker();
			this.passTB = new System.Windows.Forms.TextBox();
			this.selectPfpBTN = new System.Windows.Forms.Button();
			this.regBTN = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.confirmPassTB = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.pfpPathLBL = new System.Windows.Forms.Label();
			this.pnoTB = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// emailTB
			// 
			this.emailTB.Location = new System.Drawing.Point(205, 108);
			this.emailTB.Name = "emailTB";
			this.emailTB.Size = new System.Drawing.Size(200, 20);
			this.emailTB.TabIndex = 0;
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(205, 76);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(200, 20);
			this.nameTB.TabIndex = 1;
			// 
			// dob
			// 
			this.dob.Location = new System.Drawing.Point(205, 138);
			this.dob.Name = "dob";
			this.dob.Size = new System.Drawing.Size(200, 20);
			this.dob.TabIndex = 3;
			// 
			// passTB
			// 
			this.passTB.Location = new System.Drawing.Point(205, 199);
			this.passTB.Name = "passTB";
			this.passTB.PasswordChar = '*';
			this.passTB.Size = new System.Drawing.Size(200, 20);
			this.passTB.TabIndex = 5;
			// 
			// selectPfpBTN
			// 
			this.selectPfpBTN.Location = new System.Drawing.Point(205, 170);
			this.selectPfpBTN.Name = "selectPfpBTN";
			this.selectPfpBTN.Size = new System.Drawing.Size(75, 23);
			this.selectPfpBTN.TabIndex = 6;
			this.selectPfpBTN.Text = "Select";
			this.selectPfpBTN.UseVisualStyleBackColor = true;
			this.selectPfpBTN.Click += new System.EventHandler(this.selectPfpBTN_Click);
			// 
			// regBTN
			// 
			this.regBTN.Location = new System.Drawing.Point(205, 286);
			this.regBTN.Name = "regBTN";
			this.regBTN.Size = new System.Drawing.Size(75, 23);
			this.regBTN.TabIndex = 7;
			this.regBTN.Text = "Register";
			this.regBTN.UseVisualStyleBackColor = true;
			this.regBTN.Click += new System.EventHandler(this.regBTN_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(62, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(62, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(62, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Date of Birth";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label5.Location = new System.Drawing.Point(62, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Profile Picture";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label6.Location = new System.Drawing.Point(62, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "Password";
			// 
			// confirmPassTB
			// 
			this.confirmPassTB.Location = new System.Drawing.Point(205, 228);
			this.confirmPassTB.Name = "confirmPassTB";
			this.confirmPassTB.PasswordChar = '*';
			this.confirmPassTB.Size = new System.Drawing.Size(200, 20);
			this.confirmPassTB.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label7.Location = new System.Drawing.Point(62, 226);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Confirm Password";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(330, 286);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 16;
			this.button3.Text = "Cacnel";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// pfpPathLBL
			// 
			this.pfpPathLBL.AutoSize = true;
			this.pfpPathLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.pfpPathLBL.Location = new System.Drawing.Point(286, 175);
			this.pfpPathLBL.Name = "pfpPathLBL";
			this.pfpPathLBL.Size = new System.Drawing.Size(29, 13);
			this.pfpPathLBL.TabIndex = 17;
			this.pfpPathLBL.Text = "Path";
			// 
			// pnoTB
			// 
			this.pnoTB.Location = new System.Drawing.Point(205, 254);
			this.pnoTB.Name = "pnoTB";
			this.pnoTB.Size = new System.Drawing.Size(200, 20);
			this.pnoTB.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label8.Location = new System.Drawing.Point(62, 254);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 20);
			this.label8.TabIndex = 19;
			this.label8.Text = "Phone number";
			// 
			// RegisterScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 329);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pnoTB);
			this.Controls.Add(this.pfpPathLBL);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.confirmPassTB);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.regBTN);
			this.Controls.Add(this.selectPfpBTN);
			this.Controls.Add(this.passTB);
			this.Controls.Add(this.dob);
			this.Controls.Add(this.nameTB);
			this.Controls.Add(this.emailTB);
			this.Name = "RegisterScreen";
			this.Text = "RegisterScreen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailTB;
		private System.Windows.Forms.MaskedTextBox nameTB;
		private System.Windows.Forms.DateTimePicker dob;
		private System.Windows.Forms.TextBox passTB;
		private System.Windows.Forms.Button selectPfpBTN;
		private System.Windows.Forms.Button regBTN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox confirmPassTB;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label pfpPathLBL;
		private System.Windows.Forms.TextBox pnoTB;
		private System.Windows.Forms.Label label8;
	}
}