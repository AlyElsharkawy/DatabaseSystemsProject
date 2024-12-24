namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
    partial class StudentsGradeAssignment
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
            this.grade = new System.Windows.Forms.Button();
            this.mark = new System.Windows.Forms.NumericUpDown();
            this.download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mark)).BeginInit();
            this.SuspendLayout();
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(134, 78);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(75, 23);
            this.grade.TabIndex = 3;
            this.grade.Text = "Grade";
            this.grade.UseVisualStyleBackColor = true;
            this.grade.Click += new System.EventHandler(this.grade_Click);
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(113, 129);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(120, 20);
            this.mark.TabIndex = 4;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(134, 39);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 5;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            // 
            // StudentsGradeAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 209);
            this.Controls.Add(this.download);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.grade);
            this.Name = "StudentsGradeAssignment";
            this.Text = "StudentsGradeAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.mark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button grade;
        private System.Windows.Forms.NumericUpDown mark;
        private System.Windows.Forms.Button download;
    }
}