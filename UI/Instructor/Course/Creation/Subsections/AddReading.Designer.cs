namespace DatabaseSystemsProject.UI.Instructor.Course.Creation.Subsections
{
	partial class AddReading
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.richTextBox1.Location = new System.Drawing.Point(106, 55);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(573, 361);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(12, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 26);
			this.label1.TabIndex = 4;
			this.label1.Text = "Content";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Title";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.textBox1.Location = new System.Drawing.Point(106, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(573, 32);
			this.textBox1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.button1.Location = new System.Drawing.Point(307, 433);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 35);
			this.button1.TabIndex = 8;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// AddReading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 480);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Name = "AddReading";
			this.Text = "AddReading";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}