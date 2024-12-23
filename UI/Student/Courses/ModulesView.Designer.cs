namespace DatabaseSystemsProject.UI.Student.Courses
{
	partial class ModulesView
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
			this.modulesTV = new System.Windows.Forms.TreeView();
			this.selectBTN = new System.Windows.Forms.Button();
			this.moduleFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// modulesTV
			// 
			this.modulesTV.Location = new System.Drawing.Point(626, 12);
			this.modulesTV.Name = "modulesTV";
			this.modulesTV.Size = new System.Drawing.Size(162, 385);
			this.modulesTV.TabIndex = 0;
			// 
			// selectBTN
			// 
			this.selectBTN.Location = new System.Drawing.Point(626, 403);
			this.selectBTN.Name = "selectBTN";
			this.selectBTN.Size = new System.Drawing.Size(162, 35);
			this.selectBTN.TabIndex = 1;
			this.selectBTN.Text = "Select";
			this.selectBTN.UseVisualStyleBackColor = true;
			this.selectBTN.Click += new System.EventHandler(this.selectBTN_Click);
			// 
			// moduleFLP
			// 
			this.moduleFLP.Location = new System.Drawing.Point(12, 12);
			this.moduleFLP.Name = "moduleFLP";
			this.moduleFLP.Size = new System.Drawing.Size(587, 385);
			this.moduleFLP.TabIndex = 2;
			// 
			// ModulesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.moduleFLP);
			this.Controls.Add(this.selectBTN);
			this.Controls.Add(this.modulesTV);
			this.Name = "ModulesView";
			this.Text = "ModulesView";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView modulesTV;
		private System.Windows.Forms.Button selectBTN;
		private System.Windows.Forms.FlowLayoutPanel moduleFLP;
	}
}