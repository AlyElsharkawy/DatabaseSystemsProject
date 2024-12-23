namespace DatabaseSystemsProject.UI.Instructor.Course.Creation.Subsections
{
	partial class AddTFQ
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
			this.maxGrade = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.promptTB = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.trueRB = new System.Windows.Forms.RadioButton();
			this.falseRB = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.maxGrade)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.button1.Location = new System.Drawing.Point(523, 255);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 35);
			this.button1.TabIndex = 11;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// maxGrade
			// 
			this.maxGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.maxGrade.Location = new System.Drawing.Point(137, 203);
			this.maxGrade.Name = "maxGrade";
			this.maxGrade.Size = new System.Drawing.Size(120, 32);
			this.maxGrade.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label2.Location = new System.Drawing.Point(10, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 26);
			this.label2.TabIndex = 9;
			this.label2.Text = "Max Grade";
			// 
			// promptTB
			// 
			this.promptTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.promptTB.Location = new System.Drawing.Point(135, 12);
			this.promptTB.Name = "promptTB";
			this.promptTB.Size = new System.Drawing.Size(537, 185);
			this.promptTB.TabIndex = 8;
			this.promptTB.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 26);
			this.label1.TabIndex = 7;
			this.label1.Text = "Prompt";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label3.Location = new System.Drawing.Point(12, 264);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 26);
			this.label3.TabIndex = 12;
			this.label3.Text = "Correct Answer";
			// 
			// trueRB
			// 
			this.trueRB.AutoSize = true;
			this.trueRB.Checked = true;
			this.trueRB.Location = new System.Drawing.Point(0, 12);
			this.trueRB.Name = "trueRB";
			this.trueRB.Size = new System.Drawing.Size(47, 17);
			this.trueRB.TabIndex = 13;
			this.trueRB.TabStop = true;
			this.trueRB.Text = "True";
			this.trueRB.UseVisualStyleBackColor = true;
			// 
			// falseRB
			// 
			this.falseRB.AutoSize = true;
			this.falseRB.Location = new System.Drawing.Point(53, 12);
			this.falseRB.Name = "falseRB";
			this.falseRB.Size = new System.Drawing.Size(50, 17);
			this.falseRB.TabIndex = 14;
			this.falseRB.TabStop = true;
			this.falseRB.Text = "False";
			this.falseRB.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.trueRB);
			this.groupBox1.Controls.Add(this.falseRB);
			this.groupBox1.Location = new System.Drawing.Point(180, 255);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(106, 35);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// AddTFQ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 307);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.maxGrade);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.promptTB);
			this.Controls.Add(this.label1);
			this.Name = "AddTFQ";
			this.Text = "AddTFQ";
			((System.ComponentModel.ISupportInitialize)(this.maxGrade)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown maxGrade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox promptTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton trueRB;
		private System.Windows.Forms.RadioButton falseRB;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}