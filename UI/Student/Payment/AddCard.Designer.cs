namespace DatabaseSystemsProject.UI.Student.Payment
{
	partial class AddCard
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
			this.numberTB = new System.Windows.Forms.TextBox();
			this.typeCB = new System.Windows.Forms.ComboBox();
			this.cvvTB = new System.Windows.Forms.TextBox();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.monthTB = new System.Windows.Forms.TextBox();
			this.yearTB = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// numberTB
			// 
			this.numberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.numberTB.Location = new System.Drawing.Point(143, 55);
			this.numberTB.MaxLength = 16;
			this.numberTB.Name = "numberTB";
			this.numberTB.Size = new System.Drawing.Size(268, 32);
			this.numberTB.TabIndex = 0;
			// 
			// typeCB
			// 
			this.typeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.typeCB.FormattingEnabled = true;
			this.typeCB.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express"});
			this.typeCB.Location = new System.Drawing.Point(143, 107);
			this.typeCB.Name = "typeCB";
			this.typeCB.Size = new System.Drawing.Size(121, 33);
			this.typeCB.TabIndex = 1;
			// 
			// cvvTB
			// 
			this.cvvTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.cvvTB.Location = new System.Drawing.Point(143, 200);
			this.cvvTB.MaxLength = 3;
			this.cvvTB.Name = "cvvTB";
			this.cvvTB.Size = new System.Drawing.Size(49, 32);
			this.cvvTB.TabIndex = 3;
			// 
			// nameTB
			// 
			this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.nameTB.Location = new System.Drawing.Point(143, 242);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(268, 32);
			this.nameTB.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(35, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 26);
			this.label1.TabIndex = 5;
			this.label1.Text = "Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label2.Location = new System.Drawing.Point(35, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Type";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label3.Location = new System.Drawing.Point(35, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 26);
			this.label3.TabIndex = 7;
			this.label3.Text = "Expiration date";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label4.Location = new System.Drawing.Point(35, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 26);
			this.label4.TabIndex = 8;
			this.label4.Text = "CVV";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label5.Location = new System.Drawing.Point(35, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 26);
			this.label5.TabIndex = 9;
			this.label5.Text = "Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(214, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Month:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(325, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Year:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.button1.Location = new System.Drawing.Point(184, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 54);
			this.button1.TabIndex = 16;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// monthTB
			// 
			this.monthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.monthTB.Location = new System.Drawing.Point(260, 158);
			this.monthTB.MaxLength = 2;
			this.monthTB.Name = "monthTB";
			this.monthTB.Size = new System.Drawing.Size(49, 32);
			this.monthTB.TabIndex = 17;
			// 
			// yearTB
			// 
			this.yearTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.yearTB.Location = new System.Drawing.Point(362, 158);
			this.yearTB.MaxLength = 2;
			this.yearTB.Name = "yearTB";
			this.yearTB.Size = new System.Drawing.Size(49, 32);
			this.yearTB.TabIndex = 18;
			// 
			// AddCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 381);
			this.Controls.Add(this.yearTB);
			this.Controls.Add(this.monthTB);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameTB);
			this.Controls.Add(this.cvvTB);
			this.Controls.Add(this.typeCB);
			this.Controls.Add(this.numberTB);
			this.Name = "AddCard";
			this.Text = "AddCard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numberTB;
		private System.Windows.Forms.ComboBox typeCB;
		private System.Windows.Forms.TextBox cvvTB;
		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox monthTB;
		private System.Windows.Forms.TextBox yearTB;
	}
}