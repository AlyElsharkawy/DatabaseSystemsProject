using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Instructor.ManageStudent
{
    public partial class StudentsGrade : Form
    {
        long studentId, questionId;
        public StudentsGrade(long studentId, long questionId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.questionId = questionId;
            loadAnswer();
        }

        private void grade_Click(object sender, EventArgs e)
        {
            decimal grade = mark.Value;
            ModuleQueires.insertGrade(questionId, studentId, grade);
            Close();
        }

        private void loadAnswer()
        {
            answer.Text = SubSectionsQueries.studentSA(studentId, questionId);
            mark.Maximum = ModuleQueires.getQuestionMaxGrade(questionId);
        }

    }
}
