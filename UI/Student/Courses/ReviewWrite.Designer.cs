namespace DatabaseSystemsProject.UI.Student.Courses
{
	partial class ReviewWrite
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
            this.reviewContent = new System.Windows.Forms.TextBox();
            this.reviewRating = new System.Windows.Forms.NumericUpDown();
            this.reviewTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reviewRating)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewContent
            // 
            this.reviewContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.reviewContent.Location = new System.Drawing.Point(102, 67);
            this.reviewContent.Multiline = true;
            this.reviewContent.Name = "reviewContent";
            this.reviewContent.Size = new System.Drawing.Size(413, 113);
            this.reviewContent.TabIndex = 0;
            // 
            // reviewRating
            // 
            this.reviewRating.Location = new System.Drawing.Point(102, 199);
            this.reviewRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.reviewRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reviewRating.Name = "reviewRating";
            this.reviewRating.Size = new System.Drawing.Size(56, 20);
            this.reviewRating.TabIndex = 1;
            this.reviewRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reviewTitle
            // 
            this.reviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reviewTitle.Location = new System.Drawing.Point(102, 20);
            this.reviewTitle.Name = "reviewTitle";
            this.reviewTitle.Size = new System.Drawing.Size(282, 26);
            this.reviewTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rating";
            // 
            // submitReview
            // 
            this.submitReview.Location = new System.Drawing.Point(102, 257);
            this.submitReview.Name = "submitReview";
            this.submitReview.Size = new System.Drawing.Size(413, 23);
            this.submitReview.TabIndex = 8;
            this.submitReview.Text = "Submit";
            this.submitReview.UseVisualStyleBackColor = true;
            this.submitReview.Click += new System.EventHandler(this.submitReview_Click);
            // 
            // ReviewWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 304);
            this.Controls.Add(this.submitReview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reviewTitle);
            this.Controls.Add(this.reviewRating);
            this.Controls.Add(this.reviewContent);
            this.Name = "ReviewWrite";
            this.Text = "ReviewWrite";
            ((System.ComponentModel.ISupportInitialize)(this.reviewRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox reviewContent;
		private System.Windows.Forms.NumericUpDown reviewRating;
		private System.Windows.Forms.TextBox reviewTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button submitReview;
	}
}