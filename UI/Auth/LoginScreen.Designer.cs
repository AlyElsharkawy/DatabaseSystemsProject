namespace DatabaseSystemsProject
{
	partial class LoginScreen
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
			this.passTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.loginBTN = new System.Windows.Forms.Button();
			this.registerBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// emailTB
			// 
			this.emailTB.Location = new System.Drawing.Point(109, 161);
			this.emailTB.Name = "emailTB";
			this.emailTB.Size = new System.Drawing.Size(233, 20);
			this.emailTB.TabIndex = 0;
			// 
			// passTB
			// 
			this.passTB.Location = new System.Drawing.Point(109, 233);
			this.passTB.Name = "passTB";
			this.passTB.PasswordChar = '*';
			this.passTB.Size = new System.Drawing.Size(233, 20);
			this.passTB.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(25, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(25, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// loginBTN
			// 
			this.loginBTN.Location = new System.Drawing.Point(109, 315);
			this.loginBTN.Name = "loginBTN";
			this.loginBTN.Size = new System.Drawing.Size(75, 23);
			this.loginBTN.TabIndex = 4;
			this.loginBTN.Text = "Login";
			this.loginBTN.UseVisualStyleBackColor = true;
			this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
			// 
			// registerBTN
			// 
			this.registerBTN.Location = new System.Drawing.Point(267, 315);
			this.registerBTN.Name = "registerBTN";
			this.registerBTN.Size = new System.Drawing.Size(75, 23);
			this.registerBTN.TabIndex = 5;
			this.registerBTN.Text = "Register";
			this.registerBTN.UseVisualStyleBackColor = true;
			this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
			// 
			// LoginScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 450);
			this.Controls.Add(this.registerBTN);
			this.Controls.Add(this.loginBTN);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passTB);
			this.Controls.Add(this.emailTB);
			this.Name = "LoginScreen";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailTB;
		private System.Windows.Forms.TextBox passTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button loginBTN;
		private System.Windows.Forms.Button registerBTN;
	}
}

