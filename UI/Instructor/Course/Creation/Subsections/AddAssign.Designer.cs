namespace DatabaseSystemsProject.UI.Instructor.Course.Creation.Subsections
{
	partial class AddAssign
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
			this.pormptTB = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.maxGrade = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.maxGrade)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(12, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Prompt";
			// 
			// pormptTB
			// 
			this.pormptTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.pormptTB.Location = new System.Drawing.Point(137, 9);
			this.pormptTB.Name = "pormptTB";
			this.pormptTB.Size = new System.Drawing.Size(537, 361);
			this.pormptTB.TabIndex = 3;
			this.pormptTB.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label2.Location = new System.Drawing.Point(12, 393);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Max Grade";
			// 
			// maxGrade
			// 
			this.maxGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.maxGrade.Location = new System.Drawing.Point(137, 387);
			this.maxGrade.Name = "maxGrade";
			this.maxGrade.Size = new System.Drawing.Size(120, 32);
			this.maxGrade.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.button1.Location = new System.Drawing.Point(525, 387);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 35);
			this.button1.TabIndex = 6;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddAssign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.maxGrade);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pormptTB);
			this.Controls.Add(this.label1);
			this.Name = "AddAssign";
			this.Text = "AddAssign";
			((System.ComponentModel.ISupportInitialize)(this.maxGrade)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox pormptTB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown maxGrade;
		private System.Windows.Forms.Button button1;
	}
}