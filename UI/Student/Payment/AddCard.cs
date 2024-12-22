using DatabaseSystemsProject.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Student.Payment
{
	public partial class AddCard : Form
	{
		public AddCard()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			long number = long.Parse(numberTB.Text);
			String type = typeCB.Text;
			short expYear = short.Parse(yearTB.Text);
			byte expMonth = byte.Parse(monthTB.Text);
			String name = nameTB.Text;
			String cvv = cvvTB.Text;
			CardQueries.createBankCard(number,23,expYear,expMonth,name,type,cvv);
			Close();
		}
	}
}
