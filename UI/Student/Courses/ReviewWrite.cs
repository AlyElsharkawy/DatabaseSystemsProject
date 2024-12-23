using DatabaseSystemsProject.DB;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class ReviewWrite : Form
	{
		long cid, sid;
		public ReviewWrite(long courseID, long studentID)
		{
			InitializeComponent();
			this.cid = courseID;
			this.sid = studentID;
		}

        private void submitReview_Click(object sender, EventArgs e)
        {
			String title = reviewTitle.Text;
			String content = reviewContent.Text;
			byte rating = (byte)reviewRating.Value;
			
			CourseQueries.addReviewtoCourse(title, content, rating, cid, sid);
			Close();

        }
    }
}
