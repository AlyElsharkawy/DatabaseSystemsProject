using DatabaseSystemsProject.DB;
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
    public partial class StudentsGradeAssignment : Form
    {
        long studentId, questionId;
        public StudentsGradeAssignment(long studentId, long questionId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.questionId = questionId;
            config();
        }

        private void grade_Click(object sender, EventArgs e)
        {
            decimal grade = mark.Value;
            ModuleQueires.insertGradeAssignment(questionId, studentId, grade);
            Close();
        }

        private void config()
        {
            mark.Maximum = ModuleQueires.getQuestionMaxGradeAssignment(questionId);
        }
    }
}
