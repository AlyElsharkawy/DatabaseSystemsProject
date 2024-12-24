namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
    partial class StudentsGrade
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
            this.answer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mark)).BeginInit();
            this.SuspendLayout();
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(497, 374);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(75, 23);
            this.grade.TabIndex = 0;
            this.grade.Text = "Grade";
            this.grade.UseVisualStyleBackColor = true;
            this.grade.Click += new System.EventHandler(this.grade_Click);
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(130, 374);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(120, 20);
            this.mark.TabIndex = 1;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(23, 74);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(35, 13);
            this.answer.TabIndex = 2;
            this.answer.Text = "label1";
            // 
            // StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 429);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.grade);
            this.Name = "StudentsGrade";
            this.Text = "StudentsGrade";
            ((System.ComponentModel.ISupportInitialize)(this.mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grade;
        private System.Windows.Forms.NumericUpDown mark;
        private System.Windows.Forms.Label answer;
    }
}