using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Models;
using DatabaseSystemsProject.UI.Student.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class CoursePay : Form
	{
		BankCard usedBankCard = null;
		Course selectedCourse;
		public bool closePrev = false;
		public CoursePay(Course receivedCourse)
		{
			InitializeComponent();
			selectedCourse = receivedCourse;
			nameLBL.Text = selectedCourse.Name;
			priceLBL.Text = "Price: " + selectedCourse.price.ToString() + "$";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var allCards = new AllCards();
			allCards.ShowDialog();
			usedBankCard = allCards.selectedCard;
			if (usedBankCard == null)
			{
				return;
			}
			
			usedCardLBL.Text = usedBankCard.ID.ToString().Substring(0, 2)+"**************";
			confirmPurcBTN.Enabled = true;



		}

		private void confirmPurcBTN_Click(object sender, EventArgs e)
		{
			confirmPurcBTN.Enabled = false;
			InvoiceQueries.createInvoice(23, selectedCourse.Id, usedBankCard.ID, selectedCourse.price);
			CourseQueries.enrollStudent(23, selectedCourse.Id);
			closePrev = true;
			Close();
		}
	}
}
