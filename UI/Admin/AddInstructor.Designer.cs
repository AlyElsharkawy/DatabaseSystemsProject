namespace DatabaseSystemsProject.UI.Admin
{
	partial class AddInstructor
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
			this.pfpPathLBL = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.instructorPassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.registerInstructor = new System.Windows.Forms.Button();
			this.selectPfpBTN = new System.Windows.Forms.Button();
			this.instructorPhoneNumber = new System.Windows.Forms.TextBox();
			this.instructorDateOfBirh = new System.Windows.Forms.DateTimePicker();
			this.instructorName = new System.Windows.Forms.MaskedTextBox();
			this.instructoreEmail = new System.Windows.Forms.TextBox();
			this.instructorConfirmPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.instructorOrganisation = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// pfpPathLBL
			// 
			this.pfpPathLBL.AutoSize = true;
			this.pfpPathLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.pfpPathLBL.Location = new System.Drawing.Point(234, 116);
			this.pfpPathLBL.Name = "pfpPathLBL";
			this.pfpPathLBL.Size = new System.Drawing.Size(29, 13);
			this.pfpPathLBL.TabIndex = 34;
			this.pfpPathLBL.Text = "Path";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(278, 308);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 33;
			this.button3.Text = "Cacnel";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label7.Location = new System.Drawing.Point(10, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 20);
			this.label7.TabIndex = 32;
			this.label7.Text = "Confirm Password";
			// 
			// instructorPassword
			// 
			this.instructorPassword.Location = new System.Drawing.Point(153, 177);
			this.instructorPassword.Name = "instructorPassword";
			this.instructorPassword.PasswordChar = '*';
			this.instructorPassword.Size = new System.Drawing.Size(200, 20);
			this.instructorPassword.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label6.Location = new System.Drawing.Point(10, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 20);
			this.label6.TabIndex = 30;
			this.label6.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label5.Location = new System.Drawing.Point(10, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 20);
			this.label5.TabIndex = 29;
			this.label5.Text = "Profile Picture";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(10, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 27;
			this.label3.Text = "Date of Birth";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(10, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 26;
			this.label2.Text = "Email";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(10, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 25;
			this.label1.Text = "Name";
			// 
			// registerInstructor
			// 
			this.registerInstructor.Location = new System.Drawing.Point(153, 308);
			this.registerInstructor.Name = "registerInstructor";
			this.registerInstructor.Size = new System.Drawing.Size(75, 23);
			this.registerInstructor.TabIndex = 24;
			this.registerInstructor.Text = "Register";
			this.registerInstructor.UseVisualStyleBackColor = true;
			this.registerInstructor.Click += new System.EventHandler(this.registerInstructor_Click);
			// 
			// selectPfpBTN
			// 
			this.selectPfpBTN.Location = new System.Drawing.Point(153, 111);
			this.selectPfpBTN.Name = "selectPfpBTN";
			this.selectPfpBTN.Size = new System.Drawing.Size(75, 23);
			this.selectPfpBTN.TabIndex = 23;
			this.selectPfpBTN.Text = "Select";
			this.selectPfpBTN.UseVisualStyleBackColor = true;
			this.selectPfpBTN.Click += new System.EventHandler(this.selectPfpBTN_Click);
			// 
			// instructorPhoneNumber
			// 
			this.instructorPhoneNumber.Location = new System.Drawing.Point(153, 148);
			this.instructorPhoneNumber.MaxLength = 11;
			this.instructorPhoneNumber.Name = "instructorPhoneNumber";
			this.instructorPhoneNumber.Size = new System.Drawing.Size(200, 20);
			this.instructorPhoneNumber.TabIndex = 22;
			// 
			// instructorDateOfBirh
			// 
			this.instructorDateOfBirh.Location = new System.Drawing.Point(153, 74);
			this.instructorDateOfBirh.Name = "instructorDateOfBirh";
			this.instructorDateOfBirh.Size = new System.Drawing.Size(200, 20);
			this.instructorDateOfBirh.TabIndex = 21;
			// 
			// instructorName
			// 
			this.instructorName.Location = new System.Drawing.Point(153, 12);
			this.instructorName.Name = "instructorName";
			this.instructorName.Size = new System.Drawing.Size(200, 20);
			this.instructorName.TabIndex = 19;
			// 
			// instructoreEmail
			// 
			this.instructoreEmail.Location = new System.Drawing.Point(153, 44);
			this.instructoreEmail.Name = "instructoreEmail";
			this.instructoreEmail.Size = new System.Drawing.Size(200, 20);
			this.instructoreEmail.TabIndex = 18;
			// 
			// instructorConfirmPassword
			// 
			this.instructorConfirmPassword.Location = new System.Drawing.Point(153, 213);
			this.instructorConfirmPassword.Name = "instructorConfirmPassword";
			this.instructorConfirmPassword.PasswordChar = '*';
			this.instructorConfirmPassword.Size = new System.Drawing.Size(200, 20);
			this.instructorConfirmPassword.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label8.Location = new System.Drawing.Point(10, 148);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 20);
			this.label8.TabIndex = 36;
			this.label8.Text = "Phone number";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label9.Location = new System.Drawing.Point(10, 246);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(99, 20);
			this.label9.TabIndex = 37;
			this.label9.Text = "Organization";
			// 
			// instructorOrganisation
			// 
			this.instructorOrganisation.FormattingEnabled = true;
			this.instructorOrganisation.Location = new System.Drawing.Point(153, 248);
			this.instructorOrganisation.Name = "instructorOrganisation";
			this.instructorOrganisation.Size = new System.Drawing.Size(200, 21);
			this.instructorOrganisation.TabIndex = 38;
			// 
			// AddInstructor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 343);
			this.Controls.Add(this.instructorOrganisation);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.instructorConfirmPassword);
			this.Controls.Add(this.pfpPathLBL);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.instructorPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.registerInstructor);
			this.Controls.Add(this.selectPfpBTN);
			this.Controls.Add(this.instructorPhoneNumber);
			this.Controls.Add(this.instructorDateOfBirh);
			this.Controls.Add(this.instructorName);
			this.Controls.Add(this.instructoreEmail);
			this.Name = "AddInstructor";
			this.Text = "AddInstructor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pfpPathLBL;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox instructorPassword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button registerInstructor;
		private System.Windows.Forms.Button selectPfpBTN;
		private System.Windows.Forms.TextBox instructorPhoneNumber;
		private System.Windows.Forms.DateTimePicker instructorDateOfBirh;
		private System.Windows.Forms.MaskedTextBox instructorName;
		private System.Windows.Forms.TextBox instructoreEmail;
		private System.Windows.Forms.TextBox instructorConfirmPassword;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox instructorOrganisation;
	}
}