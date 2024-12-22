namespace DatabaseSystemsProject.UI.Admin
{
	partial class AddOrganization
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
            this.organisationName = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.organisationDescription = new System.Windows.Forms.RichTextBox();
            this.pfpPathLBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectPfpBTN = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.registerOrganisation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // organisationName
            // 
            this.organisationName.Location = new System.Drawing.Point(124, 11);
            this.organisationName.Name = "organisationName";
            this.organisationName.Size = new System.Drawing.Size(200, 20);
            this.organisationName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            // 
            // organisationDescription
            // 
            this.organisationDescription.Location = new System.Drawing.Point(124, 49);
            this.organisationDescription.Name = "organisationDescription";
            this.organisationDescription.Size = new System.Drawing.Size(442, 281);
            this.organisationDescription.TabIndex = 30;
            this.organisationDescription.Text = "";
            // 
            // pfpPathLBL
            // 
            this.pfpPathLBL.AutoSize = true;
            this.pfpPathLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.pfpPathLBL.Location = new System.Drawing.Point(205, 350);
            this.pfpPathLBL.Name = "pfpPathLBL";
            this.pfpPathLBL.Size = new System.Drawing.Size(29, 13);
            this.pfpPathLBL.TabIndex = 37;
            this.pfpPathLBL.Text = "Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Profile Picture";
            // 
            // selectPfpBTN
            // 
            this.selectPfpBTN.Location = new System.Drawing.Point(124, 345);
            this.selectPfpBTN.Name = "selectPfpBTN";
            this.selectPfpBTN.Size = new System.Drawing.Size(75, 23);
            this.selectPfpBTN.TabIndex = 35;
            this.selectPfpBTN.Text = "Select";
            this.selectPfpBTN.UseVisualStyleBackColor = true;
            this.selectPfpBTN.Click += new System.EventHandler(this.selectPfpBTN_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // registerOrganisation
            // 
            this.registerOrganisation.Location = new System.Drawing.Point(491, 345);
            this.registerOrganisation.Name = "registerOrganisation";
            this.registerOrganisation.Size = new System.Drawing.Size(75, 23);
            this.registerOrganisation.TabIndex = 38;
            this.registerOrganisation.Text = "Register";
            this.registerOrganisation.UseVisualStyleBackColor = true;
            this.registerOrganisation.Click += new System.EventHandler(this.registerOrganisation_Click);
            // 
            // AddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 443);
            this.Controls.Add(this.registerOrganisation);
            this.Controls.Add(this.pfpPathLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectPfpBTN);
            this.Controls.Add(this.organisationDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.organisationName);
            this.Name = "AddOrganization";
            this.Text = "AddOrganization";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox organisationName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox organisationDescription;
		private System.Windows.Forms.Label pfpPathLBL;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button selectPfpBTN;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button registerOrganisation;
    }
}