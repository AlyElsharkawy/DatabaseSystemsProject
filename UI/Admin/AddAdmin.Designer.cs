namespace DatabaseSystemsProject.UI.Admin
{
	partial class AddAdmin
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
            this.registerAdmin = new System.Windows.Forms.Button();
            this.adminName = new System.Windows.Forms.TextBox();
            this.adminEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adminConfirmPassword = new System.Windows.Forms.TextBox();
            this.pfpPathLBL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminProfilePic = new System.Windows.Forms.Button();
            this.adminPhoneNumber = new System.Windows.Forms.TextBox();
            this.adminDoB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // registerAdmin
            // 
            this.registerAdmin.Location = new System.Drawing.Point(16, 284);
            this.registerAdmin.Name = "registerAdmin";
            this.registerAdmin.Size = new System.Drawing.Size(75, 23);
            this.registerAdmin.TabIndex = 0;
            this.registerAdmin.Text = "Register";
            this.registerAdmin.UseVisualStyleBackColor = true;
            this.registerAdmin.Click += new System.EventHandler(this.registerAdmin_Click);
            // 
            // adminName
            // 
            this.adminName.Location = new System.Drawing.Point(155, 26);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(200, 20);
            this.adminName.TabIndex = 1;
            // 
            // adminEmail
            // 
            this.adminEmail.Location = new System.Drawing.Point(155, 57);
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(200, 20);
            this.adminEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(12, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Phone number";
            // 
            // adminConfirmPassword
            // 
            this.adminConfirmPassword.Location = new System.Drawing.Point(155, 238);
            this.adminConfirmPassword.Name = "adminConfirmPassword";
            this.adminConfirmPassword.PasswordChar = '*';
            this.adminConfirmPassword.Size = new System.Drawing.Size(200, 20);
            this.adminConfirmPassword.TabIndex = 44;
            // 
            // pfpPathLBL
            // 
            this.pfpPathLBL.AutoSize = true;
            this.pfpPathLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.pfpPathLBL.Location = new System.Drawing.Point(236, 139);
            this.pfpPathLBL.Name = "pfpPathLBL";
            this.pfpPathLBL.Size = new System.Drawing.Size(29, 13);
            this.pfpPathLBL.TabIndex = 43;
            this.pfpPathLBL.Text = "Path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Confirm Password";
            // 
            // adminPassword
            // 
            this.adminPassword.Location = new System.Drawing.Point(155, 202);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.PasswordChar = '*';
            this.adminPassword.Size = new System.Drawing.Size(200, 20);
            this.adminPassword.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Profile Picture";
            // 
            // adminProfilePic
            // 
            this.adminProfilePic.Location = new System.Drawing.Point(155, 134);
            this.adminProfilePic.Name = "adminProfilePic";
            this.adminProfilePic.Size = new System.Drawing.Size(75, 23);
            this.adminProfilePic.TabIndex = 38;
            this.adminProfilePic.Text = "Select";
            this.adminProfilePic.UseVisualStyleBackColor = true;
            this.adminProfilePic.Click += new System.EventHandler(this.adminProfilePic_Click);
            // 
            // adminPhoneNumber
            // 
            this.adminPhoneNumber.Location = new System.Drawing.Point(155, 173);
            this.adminPhoneNumber.MaxLength = 11;
            this.adminPhoneNumber.Name = "adminPhoneNumber";
            this.adminPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.adminPhoneNumber.TabIndex = 37;
            // 
            // adminDoB
            // 
            this.adminDoB.Location = new System.Drawing.Point(155, 90);
            this.adminDoB.Name = "adminDoB";
            this.adminDoB.Size = new System.Drawing.Size(200, 20);
            this.adminDoB.TabIndex = 46;
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 323);
            this.Controls.Add(this.adminDoB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adminConfirmPassword);
            this.Controls.Add(this.pfpPathLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adminProfilePic);
            this.Controls.Add(this.adminPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminEmail);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.registerAdmin);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button registerAdmin;
        private System.Windows.Forms.TextBox adminName;
        private System.Windows.Forms.TextBox adminEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adminConfirmPassword;
        private System.Windows.Forms.Label pfpPathLBL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adminProfilePic;
        private System.Windows.Forms.TextBox adminPhoneNumber;
        private System.Windows.Forms.DateTimePicker adminDoB;
    }
}