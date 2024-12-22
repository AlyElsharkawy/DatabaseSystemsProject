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

namespace DatabaseSystemsProject.UI.Student.Payment
{
	public partial class AllCards : Form
	{
		public  BankCard selectedCard = null;
		public AllCards()
		{
			InitializeComponent();
			loadCards();
		}

		private void loadCards()
		{
			var items = CardQueries.getStudentCards(23);

			foreach (var item in items)
			{
				Panel cardPanel = new Panel
				{
					Width = 350,
					Height = 100,
					Margin = new Padding(10),
					BorderStyle = BorderStyle.FixedSingle
				};

				Label cardName = new Label
				{
					Text = item.NameOnCard,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(10, 10),
					Width = 100
				};

				Label cardType = new Label
				{
					Text = item.Type,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(10, 35),
					Width = 100
				};

				Label cardNumber = new Label
				{
					Text = item.ID.ToString().Substring(0, 2) + new string('*', item.ID.ToString().Length - 2),
					Location = new Point(10, 60),
					Width = 100
				};

				Button cardBTN = new Button
				{
					Text = "Select",
					Location = new Point(250, 25),
					Width = 80,
					Height = 50
				};


				cardBTN.Click += (sender, e) => { selectedCard = item; Close(); };
				cardPanel.Controls.Add( cardName);
				cardPanel.Controls.Add(cardType);
				cardPanel.Controls.Add(cardNumber);
				cardPanel.Controls.Add(cardBTN);

				cardsFLP.Controls.Add(cardPanel);

			}
		}


	}
}
